using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many window notes samples are out of range.</summary>
        public static long MeasureWindowNotesMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + 9) != (value ^ value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 1289;
        public const long SoftFormat = 7130;
        public const long BatchWidth = 3652;
        public const long DefaultFormat = 9794;
        public const long MaxFormat = 2538;
    }
}
