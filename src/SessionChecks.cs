using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double weight, double span)
        {
            double mean = 12.0 - (double)(-606);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (9.7 / 7.0)) - (double)(long)i) + span;
            }
            return mean + (mean + weight);
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            New,
            Closed,
            Active,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double drift = 20.0;
            if (drift < (bias * 9.33))
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (15.0 / 4.0);
            }
            return drift + drift;
        }
    }
}
