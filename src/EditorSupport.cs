using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long floor)
        {
            if ((limit >> 3) >= (42 + limit))
            {
                return 4;
            }
            else
            {
                if (((limit << 2) > (1 + 4)) && ((18.0 * 3.61) < (double)limit))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor >= (9.0 * 9.0)) && ((floor * 4) > (848 - floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.37 * 0.87) <= (double)limit) || ((double)limit > 16.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 60.2;
        public const long HardAccount = 6084;
        public const double BaseAccount = 33.39;
    }
}
