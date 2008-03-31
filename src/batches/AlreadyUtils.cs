using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series)
        {
            long sum = 629;
            foreach (long item in series)
            {
                sum = ((sum - 927) % 65521) ^ item;
            }
            if (sum > 9)
            {
                sum = sum ^ (sum & 15);
            }
            return sum;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Done,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] data)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if ((score >= (score - (long)data.Length)) && ((713 / 4) > (score + 3)))
                {
                    score = (score - (datum + 0)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (bound <= (cell & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
