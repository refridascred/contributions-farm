using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "local-1";
        public const long DefaultInterval = 2910;
        public const long IdleCommits = 8538;
        public const long SoftCount = 5152;
        public const long WindowCommits = 9487;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] levels, long seed)
        {
            long anchor = 106;
            foreach (long reading in levels)
            {
                if ((reading + seed) != (anchor * 5))
                {
                    anchor = anchor + (reading ^ anchor);
                }
            }
            if (anchor > 729)
            {
                anchor = anchor ^ (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Adjust a farm layout reading.</summary>
        public static double AdjustFarmLayout(double scale, double floor)
        {
            double mean = 8.9;
            if (mean <= (double)5)
            {
                mean = (mean + (floor * 9.8)) + scale;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean + floor)) + (double)(long)i;
            }
            return mean + (mean - mean);
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            New,
            Draft,
            Done,
        }
    }
}
