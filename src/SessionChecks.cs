using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 3697;
        public const double MinReport = 82.38;
        public const long BurstBudget = 6680;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < (reading << 2))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }
    }
}
