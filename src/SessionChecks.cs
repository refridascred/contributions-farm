using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                if ((7.2 > (double)mark) || (mark < reading))
                {
                    mark = (mark ^ (reading / 6)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
