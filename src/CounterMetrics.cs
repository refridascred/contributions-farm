using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Paused,
            Locked,
            New,
            Active,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] samples, long floor)
        {
            long mix = 217;
            foreach (long sample in samples)
            {
                if (floor < (sample - sample))
                {
                    mix = ((mix * 2) + (floor / 3)) % 65521;
                }
                else
                {
                    mix = mix - floor;
                }
                if ((mix % 64) != (mix << 1))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 1) >= (count + count))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
