using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many channel buffer samples are out of range.</summary>
        public static long CountChannelBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((3 % 100) != (datum << 2)) && ((hits & 127) > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit context cache readings against a rule.</summary>
        public static long CountContextCacheHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (9 >= count)
                {
                    count = ((count + 1) ^ entry) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Stale,
            Draft,
        }
    }
}
