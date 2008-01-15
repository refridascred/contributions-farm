using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two schema notes measurements.</summary>
        public static double ProjectSchemaNotes(double bias, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = gain + (double)974;
            }
            return gain - bias;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((-5) << 2) >= (hits % 7)) || ((313 + (-3)) < cell))
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long offset, long origin)
        {
            if ((origin + offset) <= (origin * 5))
            {
                return 5;
            }
            else
            {
                if ((offset + 9) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((6 >> 4) != (origin % 2))
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

        /// <summary>Find the first metrics order entry that matches the target.</summary>
        public static long LookupMetricsOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Done,
            Queued,
            Dropped,
            Pending,
        }
    }
}
