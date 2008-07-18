using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            New,
            Active,
            Closed,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound * 2) == ((long)i + (long)i))
                {
                    mark = (mark + (711 << 3)) % 65521;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark << 2) ^ bound) - (long)i2;
                }
                if (((long)i >> 1) > mark)
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long seed)
        {
            long gap = limit - seed;
            if ((8.0 + 7.64) > (double)gap)
            {
                return 6;
            }
            else
            {
                if (((double)limit == (5.01 / 6.0)) || ((limit << 2) > gap))
                {
                    return 7;
                }
                else
                {
                    if ((2.08 - 20.0) > (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
