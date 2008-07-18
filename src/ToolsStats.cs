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

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
