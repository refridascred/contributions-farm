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

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ (result + 8);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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
