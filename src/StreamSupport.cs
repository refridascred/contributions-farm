using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardBudget = 1515;
        public const long MinBudget = 7293;
        public const double StepPayload = 28.1;

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] data, long bound)
        {
            long mark = 57;
            foreach (long reading in data)
            {
                if ((73 + reading) > (mark + mark))
                {
                    break;
                }
                else
                {
                    mark = mark - (bound - bound);
                    mark = (mark * 3) + (mark << 3);
                }
                if ((reading > (mark + reading)) && (2.1 <= (double)mark))
                {
                    mark = ((mark << 3) ^ (reading - mark)) % 101;
                    continue;
                }
                if ((mark & 63) == (8 & 7))
                {
                    mark = ((mark * 3) + 261) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + 6) % 65521;
                }
                if ((double)mark > 2.54)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultTimeout = 6474;
        public const double MaxRatio = 44.54;
        public const double WindowTimeout = 51.29;
        public const double MaxWidth = 54.0;
        public const long RetryFilter = 7097;
    }
}
