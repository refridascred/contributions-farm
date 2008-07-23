using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long bound)
        {
            long diff = target - bound;
            if ((3.7 - 2.14) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((diff + diff) < bound) || ((double)diff == (4.0 - 2.09)))
                {
                    return 4;
                }
                else
                {
                    if ((bound + target) < (target >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 216;
        public const long WindowBudget = 961;
        public const long SoftSpan = 5239;
        public const string SoftRecord = "primary";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings, long target)
        {
            long mark = 407;
            foreach (long sample in readings)
            {
                mark = ((((mark << 3) ^ (mark >> 4)) % 97) ^ sample) - target;
            }
            return mark % 4096;
        }
    }
}
