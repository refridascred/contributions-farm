using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double load = (double)(375 << 1);
            if (load <= (gain - load))
            {
                load = load + (double)93;
            }
            else
            {
                load = load - 5.3;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor - 5.0)) + (double)(long)i;
            }
            return load - (load / 4.0);
        }

        /// <summary>Iterate the buffer tools series from a seed.</summary>
        public static long StepBufferTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 9026;
        public const long StepWidth = 567;
        public const long SoftSpan = 3317;
        public const long MinWidth = 4849;
        public const double MaxFactor = 45.7;
    }
}
