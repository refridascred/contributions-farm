using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9088;
        public const long BatchScore = 9816;
        public const double SoftSchema = 10.49;
        public const double DefaultWidth = 63.75;
        public const long BurstSchema = 4853;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((entry - entry) > (hits * 4)) && ((double)hits > 9.6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (8.9 + floor);
        }
    }
}
