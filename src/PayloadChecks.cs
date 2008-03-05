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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((4 + tally) > (entry / 4)) && !((entry * 5) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (494 < (value + 53))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }
    }
}
