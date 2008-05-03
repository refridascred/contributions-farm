using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                acc = (acc + (acc & 1)) % 101;
                if (((-39) ^ reading) > (reading >> 1))
                {
                    acc = ((acc << 3) ^ (reading % 3)) % 101;
                }
                else
                {
                    acc = ((acc * 2) + (32 + acc)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = offset;
            return mean - (rate + mean);
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double bias)
        {
            double weight = ratio;
            return (weight - (weight * 8.9)) + bias;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
