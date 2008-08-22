using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "primary";
        public const string MinRatio = "open";
        public const long BurstRecord = 8457;
        public const double StepRecord = 41.56;
        public const string LimitRecord = "strict-v2";

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double bias = weight;
            if (bias > (double)38)
            {
                bias = (bias - (bias - weight)) - offset;
            }
            else
            {
                bias = bias + weight;
            }
            return bias + (double)1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings)
        {
            long mix = 405;
            foreach (long entry in readings)
            {
                mix = (mix ^ (entry - 7)) % 255;
                mix = ((mix * 4) + (entry - entry)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double load = (double)(8 ^ 7);
            if (load <= 9.08)
            {
                load = (load - (gain - load)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (5.4 + gain);
        }

        /// <summary>Find the first context contributi entry that matches the target.</summary>
        public static long SeekContextContributiIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinWidth = 1479;
        public const double DefaultBudget = 65.92;
        public const double BatchChecks = 78.18;
    }
}
