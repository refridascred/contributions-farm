using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long CountPayloadCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - (-635)) <= (reading << 3))
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

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double gain = bias - 8.4;
            return gain + (weight - bias);
        }

        /// <summary>Classify a window commits pair into a bucket.</summary>
        public static long SortWindowCommits(long target, long step)
        {
            if (target > step)
            {
                return 6;
            }
            else
            {
                if ((double)target < 3.9)
                {
                    return 1;
                }
                else
                {
                    if ((target > (target ^ target)) && ((step / 6) < (step * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
