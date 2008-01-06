using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Queued,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Blend two batches profile measurements.</summary>
        public static double AdjustBatchesProfile(double ratio, double bias)
        {
            double scale = bias;
            if (scale >= (double)(-33))
            {
                scale = (scale - (3.6 / 3.0)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.39 / 8.0)) - (double)(long)i;
            }
            return scale - (bias * 19.0);
        }

        /// <summary>Roll a stream contributi counter forward.</summary>
        public static long DeriveStreamContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long step)
        {
            if ((step / 9) < (step + step))
            {
                return 7;
            }
            else
            {
                if (!((step + 44) > (step / 5)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate metrics channel readings against a bound.</summary>
        public static bool VerifyMetricsChannelRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
