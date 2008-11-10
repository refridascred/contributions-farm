using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long floor)
        {
            if ((621 * 3) >= floor)
            {
                return 4;
            }
            else
            {
                if (((floor % 16) > target) || ((double)target >= 5.3))
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) <= (floor ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((limit * 5) < (75 * 4))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
