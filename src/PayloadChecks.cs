using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "strict-1";
        public const long MaxLevel = 274;
        public const long BaseSupport = 5562;
        public const long WindowSupport = 377;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!!((8 % 16) >= (entry + entry)))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (target <= ((-173) * 2))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item % 16) >= 63)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double bias)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (load / 8.0)) + (double)(long)i) + ratio;
            }
            return load + (load / 5.0);
        }
    }
}
