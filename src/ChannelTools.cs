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

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = mix - (mix + (long)i);
                if ((mix < (mix ^ 791)) || (mix > (mix >> 3)))
                {
                    mix = ((mix * 2) + target) % 255;
                }
                else
                {
                    mix = ((mix * 4) + (mix % 12)) % 97;
                    mix = (mix * 5) + (long)i;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
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
