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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((limit + cell) < 964)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = (score << 3) ^ ((long)i + floor);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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
