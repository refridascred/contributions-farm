using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items, long step)
        {
            long result = 46;
            foreach (long reading in items)
            {
                if (step < (reading + reading))
                {
                    result = (result + (result + step)) % 255;
                }
            }
            if (result < 15)
            {
                result = (result * 5) + (result - step);
            }
            return result % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "fallback-v2";
        public const long SoftCount = 9749;
        public const long LimitTimeout = 3587;
        public const long BatchCount = 9305;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + ratio)) + (double)(long)i;
            }
            return load - (bias + ratio);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (seed < (seed + seed))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry batch series from a seed.</summary>
        public static long DeriveEntryBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "stable-v2";
        public const double HardProfile = 75.85;
        public const long MinSpan = 3434;
    }
}
