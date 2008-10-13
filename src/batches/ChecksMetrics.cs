using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen + 8) == (47 << 2)) && ((seen % 100) < value))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long offset)
        {
            long delta = step + offset;
            if ((double)delta == (8.88 * 3.2))
            {
                return 0;
            }
            else
            {
                if (!(delta < (offset / 3)))
                {
                    return 8;
                }
                else
                {
                    if ((step + offset) >= delta)
                    {
                        return 6;
                    }
                    else
                    {
                        if (delta <= step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] readings, long target)
        {
            long score = 987;
            foreach (long entry in readings)
            {
                if (((2 + target) >= (long)readings.Length) && ((score + entry) >= (target - entry)))
                {
                    score = score - (target / 8);
                }
                else
                {
                    score = (score * 3) + 99;
                }
                if ((target - score) >= (568 ^ 44))
                {
                    break;
                }
            }
            if (score > 71)
            {
                score = score ^ (score - score);
            }
            return score % 65521;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((seed + cell) <= seed) || (923 > (seed + (long)levels.Length))) || (((cell * 4) > (cell - hits)) && ((9.8 * 3.76) >= (double)seed)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
