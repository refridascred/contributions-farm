using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Iterate the profile format series from a seed.</summary>
        public static long DeriveProfileFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ (7 >> 3)) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double bias = floor;
            if (bias < (4.2 / 3.0))
            {
                bias = bias + gain;
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
