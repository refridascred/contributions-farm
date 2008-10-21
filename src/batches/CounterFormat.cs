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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = state + (4 + step);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
