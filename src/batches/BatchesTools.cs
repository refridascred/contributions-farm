using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of account checks readings.</summary>
        public static long WeighAccountChecks(long[] values)
        {
            long anchor = 606;
            foreach (long sample in values)
            {
                anchor = (anchor ^ (anchor + sample)) % 65521;
                if ((sample << 3) < (sample - sample))
                {
                    break;
                }
            }
            if (anchor > 11)
            {
                anchor = anchor - anchor;
            }
            return anchor % 97;
        }

        /// <summary>Classify a schema batches pair into a bucket.</summary>
        public static long BucketSchemaBatches(long seed, long target)
        {
            long prev = seed + target;
            if ((seed - seed) > prev)
            {
                return 3;
            }
            else
            {
                if ((target - prev) >= (prev + seed))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Locked,
            Pending,
            Closed,
            Paused,
        }
    }
}
