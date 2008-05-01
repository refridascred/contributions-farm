using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit graph account readings against a rule.</summary>
        public static long CountGraphAccountGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (seed < hits)
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session tools value against two limits.</summary>
        public static long GradeSessionTools(long origin, long offset)
        {
            long edge = origin - offset;
            if (((double)edge < (1.8 / 4.0)) || ((origin ^ offset) > offset))
            {
                return 8;
            }
            else
            {
                if (offset <= (edge & 31))
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin <= (4.7 * 9.37)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= (origin + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + count) == (41 >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
