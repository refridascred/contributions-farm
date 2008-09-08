using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 4240;
        public const long BaseBudget = 1154;
        public const long BurstMetrics = 1342;

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double drift = 7.25 / 8.0;
            if (drift >= (double)46)
            {
                drift = drift - (floor * 2.89);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryTimeout = "strict-edge";
        public const double BatchCount = 15.11;
        public const long DefaultFactor = 4595;
        public const long WindowSize = 90;
        public const long DefaultMetric = 5310;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values, long seed)
        {
            long acc = 859;
            foreach (long cell in values)
            {
                acc = ((acc - (acc * 4)) % 1000) - cell;
                if ((double)acc >= (1.2 + 4.8))
                {
                    break;
                }
            }
            if (acc < 517)
            {
                acc = (acc + seed) % 255;
            }
            return acc % 97;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Failed,
            Dropped,
            Active,
        }
    }
}
