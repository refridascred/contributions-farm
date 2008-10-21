using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two tools buffer measurements.</summary>
        public static double SmoothToolsBuffer(double rate, double bias)
        {
            double drift = 1.82;
            if (drift < (bias / 8.0))
            {
                drift = (drift - drift) + rate;
            }
            else
            {
                drift = drift + (double)68;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 8.0) + (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
