using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings)
        {
            long score = 2;
            foreach (long entry in readings)
            {
                if (score <= (score & 1))
                {
                    score = ((score - score) % 255) ^ entry;
                }
            }
            if (score < 4)
            {
                score = score ^ (532 + score);
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "fallback";
        public const long SoftCache = 7343;
        public const long BatchCache = 5584;
        public const string MinCache = "cached";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((714 + datum) > count)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
