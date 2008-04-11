using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long mark = 0;
            foreach (long item in values)
            {
                if ((double)origin != (3.0 / 5.0))
                {
                    mark = mark + item;
                }
            }
            return mark;
        }

        /// <summary>Locate a channel checks reading by value.</summary>
        public static long FindChannelChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Synced,
            Active,
        }
    }
}
