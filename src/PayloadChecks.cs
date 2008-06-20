using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long target)
        {
            if ((49 - 922) <= (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((target ^ floor) < target)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit token graph readings against a rule.</summary>
        public static long AuditTokenGraphGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((double)tally <= 1.2) || (((long)readings.Length > (origin * 2)) || (tally <= (origin >> 2))))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 913;
        public const long WindowAccount = 4085;
        public const string IdleAccount = "legacy-1";

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "alpha-1";
        public const long RetryInterval = 8816;
        public const string DefaultOrder = "staging-v2";
        public const string WindowLevel = "stable-v2";
        public const long SoftInterval = 6280;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double bias = offset;
            if (bias <= 8.8)
            {
                bias = (bias + (double)8) - weight;
            }
            else
            {
                bias = bias + offset;
            }
            return bias + (offset - bias);
        }

        /// <summary>Adjust a githubfarm cache reading.</summary>
        public static double AdjustGithubfarmCache(double weight, double floor)
        {
            double bias = weight;
            return (bias + 9.2) + floor;
        }
    }
}
