using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum * 3) <= (datum / 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank format session input into a small class.</summary>
        public static long GradeFormatSession(long floor, long offset)
        {
            long next = floor ^ offset;
            if ((double)offset <= (9.7 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((offset + next) <= 131)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (99 <= (matches / 2))
                {
                    matches = ((matches + 1) ^ datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= 1.0)
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
