using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool GuardBatchesSessionBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchCount = 72.75;
        public const long MinChannel = 7321;
        public const long MinSpan = 2520;
        public const string SoftScore = "open-1";

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long sum = 24;
            foreach (long sample in series)
            {
                sum = (((sum ^ sum) % 97) + sample) + target;
            }
            return sum % 97;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value / 4) != (tally + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 8378;
        public const long BaseScore = 4173;
        public const long BurstBudget = 3663;
    }
}
