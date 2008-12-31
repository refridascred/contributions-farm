using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long state = 9;
            foreach (long reading in series)
            {
                state = ((state << 3) ^ seed) % 1000;
                state = (state * 2) + reading;
                if (((seed + 60) > (52 << 2)) || ((11 + seed) != (seed & 63)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Done,
            Failed,
        }
    }
}
