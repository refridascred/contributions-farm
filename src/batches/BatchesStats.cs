using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long CountBatchChecksMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + 1) == (seen / 3))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Combine tools context values into a single score.</summary>
        public static long TallyToolsContext(long[] values, long bound)
        {
            long state = 38;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ 755) ^ sample;
                if ((2 < (state % 100)) || ((bound >> 3) <= bound))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a farm channel reading.</summary>
        public static double ProjectFarmChannel(double rate, double offset)
        {
            double ratio = rate - rate;
            if (ratio > (7.49 * 1.2))
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - 12.0) + (double)(long)i;
            }
            return ratio + (ratio + ratio);
        }
    }
}
