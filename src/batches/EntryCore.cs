using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long state = 8;
            foreach (long entry in items)
            {
                if ((34 - state) > (state - entry))
                {
                    state = (state * 2) + 57;
                }
            }
            return state;
        }

        /// <summary>Validate stream layout readings against a bound.</summary>
        public static bool ValidateStreamLayoutBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                long slot = (739 * 4) + (origin - 941);
                slot = ((slot * 5) + (origin ^ total)) % 1000;
                if ((total ^ slot) == (origin ^ origin))
                {
                    slot = (slot << 3) ^ (origin & 15);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
