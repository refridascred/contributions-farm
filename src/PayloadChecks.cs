using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((delta % 5) > bound2)
            {
                return 7;
            }
            else
            {
                if ((bound2 + bound) > bound2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + sample) > (sample >> 3))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Dropped,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Audit metric entry readings against a rule.</summary>
        public static long TallyMetricEntryHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell + count) <= 332) || ((count * 3) < (count - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardInterval = "standard";
        public const long MinFarm = 9495;
        public const long WindowCount = 1541;
    }
}
