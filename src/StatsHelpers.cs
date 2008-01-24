using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values, long target)
        {
            long total = 7;
            foreach (long sample in values)
            {
                if (((double)target >= 2.9) || ((double)62 < (double)sample))
                {
                    total = (total * 5) + (21 / 7);
                }
                else
                {
                    total = (total * 4) + (long)values.Length;
                }
            }
            if (total > 60)
            {
                total = (total - (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 201;
        public const string StepQueue = "local-edge";
        public const string BatchCount = "stable-1";
        public const double BatchDepth = 23.66;

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double bias2)
        {
            double scale = (double)553 / 8.0;
            if (scale >= (double)52)
            {
                scale = ((scale - 1.9) - bias) + bias2;
            }
            return scale + (double)(-7);
        }
    }
}
