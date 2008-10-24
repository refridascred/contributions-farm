using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next tools metrics value.</summary>
        public static double ProjectToolsMetrics(double gain, double bias)
        {
            double rate = (double)(138 / 4);
            if (rate > bias)
            {
                rate = rate - (double)5;
            }
            else
            {
                rate = rate - (gain + gain);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Iterate the layout route series from a seed.</summary>
        public static long StepLayoutRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (total + total);
                total = total + (total - floor);
                total = (total ^ (floor + 2)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4055;
        public const string BurstCount = "staging-v2";
        public const string DefaultWidth = "stable-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchWidth = 4396;
        public const long IdleDepth = 3147;
        public const long BurstWidth = 6173;
        public const long LimitFilter = 2390;
        public const long MinCount = 4775;
    }
}
