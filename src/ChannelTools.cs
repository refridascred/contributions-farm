using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a metrics metric reading by value.</summary>
        public static long SeekMetricsMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Draft,
            Idle,
            Closed,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
