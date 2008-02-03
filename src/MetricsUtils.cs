using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Idle,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result * 4) + ((long)i * 5);
                result = (result - (offset + result)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target - target) == (55 + 536))
                {
                    acc = acc ^ acc;
                }
                if ((acc >> 1) == (target - acc))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 65521;
                    acc = acc - (4 % 64);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item * 5) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double span)
        {
            double bias = (span / 9.0) - ratio;
            return bias + (ratio * 9.81);
        }
    }
}
