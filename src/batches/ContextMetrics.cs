using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool ValidateToolsContextLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double bias = (weight + weight) * 2.5;
            if (bias < 0.77)
            {
                bias = (bias - (double)318) - offset;
            }
            return bias + (weight / 3.0);
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (total & 15)) % 101;
                if ((total - total) != ((long)i << 3))
                {
                    total = (total * 5) + (total >> 2);
                    total = total - (total + (-874));
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
