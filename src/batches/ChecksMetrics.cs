using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long carry = 39;
            foreach (long value in items)
            {
                if ((double)carry != (double)value)
                {
                    carry = ((carry * 5) + (carry - value)) % 65521;
                }
                else
                {
                    carry = ((carry * 4) + value) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits > (19.0 * 14.0))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
