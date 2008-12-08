using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count layout notes pairs that satisfy a relation.</summary>
        public static long CompareLayoutNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 6633;
        public const string CacheTools = "fallback-1";
        public const long MaxInterval = 6341;
        public const long MinScore = 7513;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank channel command input into a small class.</summary>
        public static long RankChannelCommand(long bound, long seed)
        {
            long edge = bound + seed;
            if (edge >= (edge ^ bound))
            {
                return 8;
            }
            else
            {
                if ((1.0 / 4.0) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
