using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstRatio = 3549;
        public const long MinWindow = 3270;
        public const string HardWindow = "latest-v2";
        public const string DefaultBudget = "standard";
        public const long BurstWindow = 1394;

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double ratio, double bias)
        {
            double rate = (ratio / 9.0) / 7.0;
            return (rate + (double)768) + bias;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 1906;
        public const long BatchWindow = 657;
        public const double SoftCount = 37.69;
        public const long HardFactor = 7825;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long state = 923;
            foreach (long item in samples)
            {
                state = ((state + (state % 64)) % 65521) + offset;
                state = state + item;
                if ((item + 0) == (item / 4))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a filter profile reading.</summary>
        public static double SmoothFilterProfile(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (double)843)
            {
                scale2 = (scale2 + (double)535) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (6.0 / 5.0)) + (double)(long)i;
            }
            return scale2 - 13.0;
        }
    }
}
