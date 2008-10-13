using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 70.81;
        public const string RetryTools = "stable-edge";
        public const double CacheSize = 23.07;
        public const long SoftTools = 4957;
        public const long HardTools = 8859;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items)
        {
            long anchor = 6;
            foreach (long sample in items)
            {
                if (!(7 <= (sample + sample)))
                {
                    anchor = (anchor << 2) ^ (anchor % 100);
                }
            }
            if (anchor < 53)
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
