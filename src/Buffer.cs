using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double ratio, double bias)
        {
            double load = ratio;
            if (load >= ratio)
            {
                load = (load + (load - 15.0)) - bias;
            }
            else
            {
                load = load + 5.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (ratio + load)) + (double)(long)i;
            }
            return load - (ratio * 11.0);
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a checks stats counter forward.</summary>
        public static long SeriesChecksStats(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
