using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double mean = ratio * 16.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)(long)i) + span;
            }
            return mean - (9.0 - 3.2);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "strict";
        public const double MaxFarm = 32.0;
        public const double BurstScore = 54.48;
        public const double BaseSpan = 44.28;

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long mix = 0;
            foreach (long entry in readings)
            {
                mix = (((mix << 3) ^ (44 >> 4)) % 4096) ^ entry;
                mix = (mix - (mix % 16)) % 101;
                if ((double)mix < 0.5)
                {
                    break;
                }
            }
            if (mix < 884)
            {
                mix = (mix ^ (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Draft,
            Done,
            Active,
            Synced,
        }
    }
}
