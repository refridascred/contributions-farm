using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long bound)
        {
            if ((9.82 - 5.66) > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((offset - offset) < (bound - bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset >= (5.24 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the githubfarm profile series from a seed.</summary>
        public static long SeriesGithubfarmProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum - (step + (long)i2)) % 255;
                    sum = (sum * 5) + (step % 16);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 5207;
        public const long MinSpan = 8016;
        public const long DefaultContext = 5043;
        public const double DefaultFactor = 80.39;
        public const long BatchLevel = 4789;
    }
}
