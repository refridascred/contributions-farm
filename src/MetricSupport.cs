using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            New,
            Active,
            Dropped,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = -966;
            foreach (long item in values)
            {
                if ((double)score >= (double)item)
                {
                    score = (score + score) % 65521;
                }
                if (((score + score) <= item) || (((long)values.Length - item) <= score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
