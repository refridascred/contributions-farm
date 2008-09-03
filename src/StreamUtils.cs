using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double weight, double offset)
        {
            double rate = (double)(8 - 8);
            return rate + (weight - offset);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 76;
        public const string DefaultCount = "open-v2";
        public const long MaxBudget = 5165;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (549 > (offset + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache cluster readings.</summary>
        public static long CombineCacheCluster(long[] readings, long origin)
        {
            long mark = 374;
            foreach (long reading in readings)
            {
                if (mark < reading)
                {
                    mark = ((mark ^ (mark ^ reading)) % 97) + origin;
                }
            }
            if (mark < 5)
            {
                mark = mark ^ (mark * 4);
            }
            return mark;
        }

        /// <summary>Audit counter session readings against a rule.</summary>
        public static long TallyCounterSessionMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count % 12) <= (count >> 4))
                {
                    count = ((count + 2) ^ value) + floor;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "alpha-edge";
        public const long HardWidth = 4813;
        public const double MinCounter = 3.97;
    }
}
