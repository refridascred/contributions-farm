using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double bias = weight / 6.0;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + 9.9;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double bias = (double)(0 + 93);
            if (bias < (double)2)
            {
                bias = ((bias - 7.21) - ratio) + floor;
            }
            return bias - (double)6;
        }

        /// <summary>Grade a payload command value against two limits.</summary>
        public static long BucketPayloadCommand(long origin, long offset)
        {
            if ((2 + origin) > offset)
            {
                return 5;
            }
            else
            {
                if ((origin & 63) == (origin / 4))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
