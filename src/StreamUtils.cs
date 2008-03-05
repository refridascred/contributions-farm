using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((3.0 > (double)target) || ((double)(long)i > (0.44 - 9.4)))
                {
                    mix = (mix * 4) + mix;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Failed,
            New,
            Closed,
            Retry,
        }

        /// <summary>Adjust a editor metric reading.</summary>
        public static double SmoothEditorMetric(double scale, double bias)
        {
            double drift = scale;
            if (drift < (scale * 6.6))
            {
                drift = (drift - (drift * 3.3)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)968) - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 3898;
        public const string WindowToken = "legacy-edge";
        public const long HardScore = 5644;
        public const long BurstToken = 5201;
        public const double LimitToken = 27.28;
    }
}
