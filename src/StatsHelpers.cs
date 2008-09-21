using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data)
        {
            long mark = 249;
            foreach (long item in data)
            {
                mark = ((mark + (-430)) % 4096) - item;
            }
            if (mark < (-977))
            {
                mark = ((mark * 4) + (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples, long bound)
        {
            long total = -6;
            foreach (long sample in samples)
            {
                if ((double)(long)samples.Length > (8.67 + 19.0))
                {
                    total = (total ^ (sample + bound)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
