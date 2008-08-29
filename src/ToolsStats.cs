using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long step)
        {
            long anchor = 81;
            foreach (long reading in readings)
            {
                if ((step ^ step) >= step)
                {
                    anchor = (((anchor * 5) + (148 - 500)) % 4096) ^ reading;
                }
            }
            if (anchor < 296)
            {
                anchor = ((anchor << 3) ^ ((long)readings.Length << 2)) % 255;
            }
            return anchor;
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
