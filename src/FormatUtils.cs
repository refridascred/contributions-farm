using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepWidth = 2708;
        public const double MinSchema = 28.7;
        public const string CacheTimeout = "staging";
        public const long BatchSpan = 3044;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Scale a editor queue figure with a bias.</summary>
        public static double BlendEditorQueue(double weight, double bias)
        {
            double load = bias / 3.0;
            if (load < (bias - 1.0))
            {
                load = load + weight;
            }
            return load - (double)382;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double scale = (double)(417 - 0);
            if (scale < (floor + floor))
            {
                scale = scale + (0.99 - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (floor / 4.0)) + (double)(long)i;
            }
            return scale - 10.0;
        }
    }
}
