using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double drift = (ratio * 6.6) + (ratio * 1.21);
            if (drift <= bias)
            {
                drift = drift - (3.2 * 3.9);
            }
            else
            {
                drift = drift + 5.82;
            }
            return drift - (bias + ratio);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double floor)
        {
            double drift = (double)(691 & 127);
            if (drift <= 9.76)
            {
                drift = drift - (bias * 2.02);
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift + 1.6;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] levels, long origin)
        {
            long score = -5;
            foreach (long cell in levels)
            {
                score = (((score << 2) ^ (cell * 2)) % 101) - origin;
            }
            if (score < 385)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Paused,
            Idle,
            Locked,
        }
    }
}
