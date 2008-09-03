using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheFactor = 8.96;
        public const string LimitLevel = "cached-v2";
        public const long BurstSize = 4051;
        public const string BaseFactor = "legacy-edge";

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 95.87;
        public const long BatchBatches = 2022;
        public const long WindowDepth = 8250;
        public const long StepScore = 844;

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
