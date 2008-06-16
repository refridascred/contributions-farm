using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if ((double)45 <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((step > seed) && ((double)seed == (10.0 + 6.8)))
                {
                    return 3;
                }
                else
                {
                    if ((step + step) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ step) <= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Draft,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long cell in samples)
            {
                if (offset < (cell ^ offset))
                {
                    anchor = ((anchor << 3) ^ (cell ^ cell)) % 97;
                }
            }
            if (anchor > 75)
            {
                anchor = (anchor + (offset - offset)) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            long next = origin + floor;
            if (((floor + next) < next) && ((origin + origin) >= next))
            {
                return 5;
            }
            else
            {
                if ((14.0 / 7.0) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((2.3 / 8.0) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
