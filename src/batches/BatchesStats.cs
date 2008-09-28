using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every command filter entry stays within the limit.</summary>
        public static bool VerifyCommandFilterRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window stream entries.</summary>
        public static long WeighWindowStream(long[] samples)
        {
            long score = 8;
            foreach (long reading in samples)
            {
                if ((14.0 - 5.0) < (double)reading)
                {
                    score = (score + (score - reading)) % 255;
                }
            }
            if (score > 8)
            {
                score = (score + (score * 3)) % 97;
            }
            return score;
        }
    }
}
