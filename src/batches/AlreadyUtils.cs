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

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Pending,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next farm format value.</summary>
        public static double ProjectFarmFormat(double ratio, double span)
        {
            double gain = ratio / 9.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - gain) - (double)(long)i) - span;
            }
            return gain + 1.0;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
