using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate filter route samples.</summary>
        public static long ScoreFilterRoute(long[] items)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                acc = (acc * 5) + reading;
            }
            return acc % 97;
        }
    }
}
