using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long origin)
        {
            long diff = seed ^ origin;
            if ((origin <= (seed ^ seed)) || ((origin + 6) <= (seed ^ 2)))
            {
                return 7;
            }
            else
            {
                if ((origin - diff) <= (632 & 15))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (0.7 + 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(((reading >> 1) > tally) || ((reading << 1) < (floor + floor))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
