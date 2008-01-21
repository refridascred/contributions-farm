using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long bound)
        {
            if ((1.6 * 8.01) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (669 > (79 + bound))
                {
                    return 5;
                }
                else
                {
                    if (((limit * 4) <= bound) || ((double)bound < 11.0))
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

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series)
        {
            long total = 0;
            foreach (long cell in series)
            {
                total = ((total * 2) + (total << 3)) % 101;
                if (!((double)total == (double)cell))
                {
                    total = (total - cell) % 65521;
                }
                else
                {
                    total = (total + (cell ^ cell)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ ((long)i - limit);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 20.18;
        public const double BaseScore = 4.92;
        public const long DefaultLevel = 2532;
        public const long WindowStats = 9067;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Retry,
            Queued,
            New,
            Stale,
        }
    }
}
