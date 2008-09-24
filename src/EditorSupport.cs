using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Size { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long seed, long floor)
        {
            if (((floor + seed) < (seed + floor)) && ((7.2 / 6.0) <= (double)floor))
            {
                return 0;
            }
            else
            {
                if (((seed - seed) < (floor * 2)) && ((seed + 63) >= (seed / 4)))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 5) != (floor ^ seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double floor)
        {
            double drift = floor;
            if (drift > (bias / 7.0))
            {
                drift = drift - bias;
            }
            return drift - (bias / 3.0);
        }
    }
}
