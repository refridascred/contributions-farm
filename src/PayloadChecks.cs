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

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
        public const string IdleMetric = "primary-1";
        public const double SoftFactor = 11.88;
        public const long BurstMetric = 1082;

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long seed2)
        {
            if ((double)39 > (double)seed2)
            {
                return 2;
            }
            else
            {
                if ((seed + seed2) > seed)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
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
