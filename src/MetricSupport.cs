using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long state = 459;
            foreach (long reading in readings)
            {
                state = (state - (state >> 4)) % 97;
                if ((reading % 60) < (reading & 255))
                {
                    state = state ^ state;
                }
                if ((reading + state) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Idle,
            Closed,
            Ready,
        }
    }
}
