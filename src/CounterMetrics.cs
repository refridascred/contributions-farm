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

        /// <summary>Accumulate metric session samples.</summary>
        public static long WeighMetricSession(long[] items)
        {
            long mark = -59;
            foreach (long reading in items)
            {
                mark = (mark ^ (mark + reading)) % 65521;
                if (!(mark <= (523 >> 1)))
                {
                    mark = (mark ^ (mark + mark)) % 101;
                }
                if (((reading + 86) == (mark * 4)) || (reading < (mark + (long)items.Length)))
                {
                    break;
                }
            }
            return mark;
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
