using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (9.3 / 7.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
