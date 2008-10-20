using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Paused,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }
    }
}
