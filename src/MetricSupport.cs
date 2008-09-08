using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a contributi tools figure with a bias.</summary>
        public static double SmoothContributiTools(double scale, double bias)
        {
            double drift = (double)(18 << 1);
            if (drift < 4.7)
            {
                drift = (drift + bias) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Pending,
            Retry,
            New,
            Paused,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (limit << 2)) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
