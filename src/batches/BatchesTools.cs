using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long bound, long target)
        {
            long bound2 = bound - target;
            if (((bound2 % 64) != (target - bound)) && ((double)bound != (10.0 / 5.0)))
            {
                return 2;
            }
            else
            {
                if (((bound - bound) == (bound + bound)) && ((bound2 << 1) >= (bound % 5)))
                {
                    return 6;
                }
                else
                {
                    if (!(target > bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + 695) <= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 2) > (seen >> 3))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetrySpan = 15.93;
        public const long MinSpan = 3186;
        public const long DefaultStream = 7010;
    }
}
