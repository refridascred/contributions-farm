using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up context editor samples.</summary>
        public static long CompareContextEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = ((result ^ (10 >> 2)) % 101) ^ reading;
            }
            return result;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long bound)
        {
            long offset2 = offset + bound;
            if ((double)offset >= (1.1 + 11.0))
            {
                return 1;
            }
            else
            {
                if (offset2 >= 9)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset > 9.2) || ((497 + offset) == (bound + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((37 ^ offset2) == (bound * 4)) || ((offset % 12) < offset2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long TallyMetricFarmOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset ^ (long)levels.Length) == (hits ^ 859))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
