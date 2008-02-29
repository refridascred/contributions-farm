using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Check that every profile already entry stays within the limit.</summary>
        public static bool ValidateProfileAlreadyLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0.99 - 5.82) >= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data)
        {
            long score = 4;
            foreach (long item in data)
            {
                score = (score * 3) + (item << 1);
            }
            return score % 65521;
        }

        /// <summary>Classify a counter stream pair into a bucket.</summary>
        public static long SortCounterStream(long target, long bound)
        {
            long diff = target - bound;
            if ((diff / 6) <= diff)
            {
                return 2;
            }
            else
            {
                if (target < (diff + diff))
                {
                    return 3;
                }
                else
                {
                    if ((bound % 100) == (target >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
