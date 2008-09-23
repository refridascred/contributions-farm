using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor - step) % 101) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of batch command readings.</summary>
        public static long CombineBatchCommand(long[] items, long bound)
        {
            long total = 74;
            foreach (long cell in items)
            {
                if ((5.7 * 3.0) != (double)cell)
                {
                    total = (((total * 2) + 64) % 255) + bound;
                }
            }
            return total;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double ratio = rate / 2.0;
            if (ratio > (3.93 - ratio))
            {
                ratio = ratio - (ratio * 7.0);
            }
            else
            {
                ratio = ratio - (bias * 13.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
