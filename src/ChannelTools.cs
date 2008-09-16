using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of report channel readings.</summary>
        public static long FoldReportChannel(long[] values)
        {
            long total = 967;
            foreach (long cell in values)
            {
                total = (total << 2) ^ (cell / 3);
                total = ((total * 4) + (-571)) % 65521;
            }
            return total;
        }
    }
}
