using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double weight = floor + (scale * 9.36);
            if (weight > floor)
            {
                weight = weight - (double)729;
            }
            else
            {
                weight = weight - floor;
            }
            return weight + (weight + 4.34);
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((10.0 * 6.9) < (double)bound)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long limit, long target)
        {
            long diff = limit - target;
            if (!((diff ^ target) < (target + limit)))
            {
                return 4;
            }
            else
            {
                if ((double)target <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((diff > (diff + limit)) || (limit >= 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
