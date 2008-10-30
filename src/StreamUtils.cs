using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the context filter series from a seed.</summary>
        public static long RollContextFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long origin, long seed)
        {
            long lane = origin + seed;
            if (!(origin <= (origin + lane)))
            {
                return 6;
            }
            else
            {
                if ((origin + origin) == (lane ^ lane))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metrics buffer readings against a rule.</summary>
        public static long MeasureMetricsBufferHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (9.5 / 6.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
