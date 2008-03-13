using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next session schema value.</summary>
        public static double SmoothSessionSchema(double ratio, double span)
        {
            double weight = 10.0;
            if (weight > (span - ratio))
            {
                weight = weight + 8.5;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (9.1 / 4.0)) + (double)(long)i;
            }
            return weight + (weight * 4.03);
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long bound)
        {
            long total = 5;
            foreach (long reading in data)
            {
                if ((3 ^ total) < total)
                {
                    total = ((total << 2) ^ (bound / 7)) - reading;
                }
            }
            return total;
        }
    }
}
