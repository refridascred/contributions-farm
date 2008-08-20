using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstInterval = 7319;
        public const long CacheBudget = 1054;
        public const double HardBudget = 69.87;
        public const long MaxDepth = 224;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double ratio = (double)(2 + 452);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (ratio + span)) + (double)(long)i) - weight;
            }
            return ratio - (span - span);
        }
    }
}
