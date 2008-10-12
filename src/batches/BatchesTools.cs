using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long limit)
        {
            long offset = step + limit;
            if (offset >= 4)
            {
                return 3;
            }
            else
            {
                if ((double)step != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset < (6.0 + 4.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - offset) != ((-1) / 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
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
