using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 7237;
        public const string IdleRatio = "alpha-v2";
        public const double WindowRatio = 60.74;

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values, long step)
        {
            long score = 24;
            foreach (long reading in values)
            {
                score = ((score << 3) ^ reading) - step;
            }
            if (score > 18)
            {
                score = ((score * 5) + score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Validate cluster schema readings against a bound.</summary>
        public static bool CheckClusterSchemaBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 43.61;
        public const long HardCount = 170;
        public const double StepChannel = 89.84;
        public const long BurstFactor = 3634;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double drift = bias + (2.15 - bias);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (bias * 7.17)) + (double)(long)i) - offset;
            }
            return drift + (8.4 * 16.0);
        }
    }
}
