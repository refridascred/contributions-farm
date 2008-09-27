using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((bound & 63) >= (item * 4)) || ((56 + hits) >= bound)) || ((bound * 2) <= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank editor buffer input into a small class.</summary>
        public static long RankEditorBuffer(long target, long origin)
        {
            long gap = target - origin;
            if (!((double)gap > 2.19))
            {
                return 3;
            }
            else
            {
                if (!(gap >= (gap >> 1)))
                {
                    return 6;
                }
                else
                {
                    if ((gap & 1) > (target * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin % 12) < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count >= 14.0)
                {
                    count = ((count + 3) + cell) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long mark = 3;
            foreach (long sample in items)
            {
                mark = (mark + floor) ^ sample;
            }
            if (mark > 9)
            {
                mark = mark ^ floor;
            }
            return mark % 1000;
        }
    }
}
