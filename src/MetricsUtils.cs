using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] levels, long target)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((target + sum) < (target * 4))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = sum ^ (322 + reading);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings)
        {
            long anchor = 25;
            foreach (long reading in readings)
            {
                anchor = (anchor ^ (reading & 31)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) == (count + 254))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
