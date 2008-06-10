using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long bound, long step)
        {
            if ((step >= (bound << 1)) && ((step % 100) < (step % 97)))
            {
                return 6;
            }
            else
            {
                if ((4.0 * 8.2) < (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((step ^ step) <= (step + 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((2.0 - 6.39) != (double)bound) || ((step + step) >= (step << 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryScore = 1122;
        public const double SoftSpan = 25.07;
        public const long StepCluster = 7339;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((52 & 31) > target)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
