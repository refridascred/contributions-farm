using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Queued,
            Locked,
        }

        /// <summary>Count githubfarm queue pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many record format samples are out of range.</summary>
        public static long CountRecordFormatOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry << 1) < (floor << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a report farm value against two limits.</summary>
        public static long GradeReportFarm(long offset, long target)
        {
            long cur = offset - target;
            if (cur < target)
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + total) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank window counter input into a small class.</summary>
        public static long ClassifyWindowCounter(long limit, long seed)
        {
            long next = limit ^ seed;
            if (((seed + limit) < 653) && ((double)next > (double)seed))
            {
                return 8;
            }
            else
            {
                if (((next + 977) < (3 + 87)) || (limit >= (limit - limit)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
