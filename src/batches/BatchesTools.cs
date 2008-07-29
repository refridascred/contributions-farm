using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!((cell / 4) <= (cell >> 1)))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long origin)
        {
            if (origin <= (origin + 649))
            {
                return 6;
            }
            else
            {
                if (!((limit + origin) != (limit & 7)))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 255) != (limit >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
