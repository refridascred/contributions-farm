using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Done,
            New,
            Ready,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double gain = bias + bias;
            if (gain < (bias / 9.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)584) + (double)(long)i;
            }
            return gain - bias2;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleLevel = 2189;
        public const long IdleFilter = 5490;
        public const long SoftFilter = 6857;
        public const string CacheFilter = "stable-v2";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
