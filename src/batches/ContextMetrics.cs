using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double offset)
        {
            double ratio = (double)213 / 8.0;
            if (ratio < ratio)
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - (5.0 / 7.0);
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Idle,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstLevel = 7906;
        public const long MinLevel = 3640;
        public const string BurstCount = "cached-v2";
        public const long BatchInterval = 6894;
        public const double RetryDepth = 98.39;

        /// <summary>Audit queue layout readings against a rule.</summary>
        public static long MeasureQueueLayoutMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!(matches < 31))
                {
                    matches = ((matches + 1) + entry) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema editor figure with a bias.</summary>
        public static double ScaleSchemaEditor(double scale, double floor)
        {
            double ratio = 9.9;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + floor) - (double)(long)i) - scale;
            }
            return ratio + ratio;
        }
    }
}
