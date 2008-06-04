using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of order metric entries.</summary>
        public static long TallyOrderMetric(long[] levels)
        {
            long mark = 6;
            foreach (long entry in levels)
            {
                if ((entry - mark) < (entry << 3))
                {
                    mark = ((mark * 3) + (7 / 6)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                double load = (double)seed * 4.72;
                if (!(total <= (seed + seed)))
                {
                    total = (total << 2) ^ (seed / 5);
                }
                if (((long)i < seed) && ((load + load) <= load))
                {
                    load = load - load;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
