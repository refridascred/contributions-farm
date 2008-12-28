using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long offset)
        {
            long state = -77;
            foreach (long datum in readings)
            {
                state = (state ^ (datum * 3)) + offset;
            }
            return state % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((616 + seen) < seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheBudget = "open-edge";
        public const string SoftCount = "latest-v2";
        public const long HardInterval = 113;
        public const string IdleDepth = "latest-edge";

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long acc = 0;
            foreach (long value in values)
            {
                acc = ((acc << 2) ^ (5 + value)) % 101;
                if (167 >= (value - value))
                {
                    acc = (acc + (value - acc)) % 97;
                }
            }
            if (acc > 84)
            {
                acc = (acc << 2) ^ (acc & 63);
            }
            return acc % 97;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((9.03 * 2.37) != (double)seed)
            {
                return 3;
            }
            else
            {
                if (!(seed <= (seed + 1)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)seed == (double)span))
                    {
                        return 0;
                    }
                    else
                    {
                        if (4.1 < (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSpan = 3217;
        public const long StepSupport = 5124;
        public const double RetryDepth = 67.02;
        public const long MinSupport = 2356;
    }
}
