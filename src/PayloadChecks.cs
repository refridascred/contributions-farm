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

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data, long origin)
        {
            long mark = 5;
            foreach (long item in data)
            {
                mark = ((mark * 4) + (91 - 572)) ^ item;
            }
            if (mark > 23)
            {
                mark = (mark << 3) ^ (origin & 7);
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardInterval = "standard";
        public const long MinFarm = 9495;
        public const long WindowCount = 1541;
    }
}
