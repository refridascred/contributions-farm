using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i % 64) > (origin << 1))
                {
                    sum = (sum + (origin % 7)) % 4096;
                    sum = (sum + sum) % 97;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "legacy-1";
        public const long CacheFactor = 2315;
        public const long MaxWindow = 1226;
        public const string BurstDepth = "alpha";
        public const long LimitWindow = 7255;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double load = gain;
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheSpan = 48.17;
        public const string WindowBatch = "stable-v2";
        public const long DefaultScore = 5464;

        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long TallyBatchesCounterOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((5.5 * 6.09) < (double)matches)
                {
                    matches = ((matches + 1) + reading) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
