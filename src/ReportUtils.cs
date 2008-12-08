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

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double ratio = (gain / 6.0) * 4.2;
            if (ratio <= (double)39)
            {
                ratio = (ratio - (ratio * 10.0)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio / 7.0)) + (double)(long)i;
            }
            return ratio - (6.5 - gain);
        }

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
