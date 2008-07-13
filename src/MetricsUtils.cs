using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool CheckAlreadyCommitsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next account cache value.</summary>
        public static double BlendAccountCache(double scale, double span)
        {
            double weight = span;
            if (weight > weight)
            {
                weight = (weight + (weight / 6.0)) - scale;
            }
            else
            {
                weight = weight + (weight * 3.34);
            }
            return weight - (span / 2.0);
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "alpha-1";
        public const string RetryDepth = "fallback-v2";
        public const long MinScore = 9129;
        public const long BurstGraph = 9506;

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double weight = (double)(733 + 6);
            if (weight < (weight - bias))
            {
                weight = weight - (offset * 4.4);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 16.0) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
