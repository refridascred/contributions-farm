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

        /// <summary>Match up format profile samples.</summary>
        public static long CompareFormatProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
