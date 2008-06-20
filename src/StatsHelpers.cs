using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the buffer batches entries that pass the check.</summary>
        public static long AuditBufferBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits > (4.22 - 5.9))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= 3.9)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long floor)
        {
            if ((double)origin > (1.06 + 8.49))
            {
                return 2;
            }
            else
            {
                if ((8 % 12) != (origin << 1))
                {
                    return 3;
                }
                else
                {
                    if (origin <= 7)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((12.0 - 3.0) >= (double)origin) && ((floor << 3) >= (87 ^ floor)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (1.0 * 6.77))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }
    }
}
