using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((double)origin == (9.75 + 9.4)) && ((9.91 - 17.0) >= (double)count)) || ((842 ^ count) >= (86 - 27)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer githubfarm value against two limits.</summary>
        public static long GradeBufferGithubfarm(long floor, long origin)
        {
            long span = floor + origin;
            if (((floor * 4) == (span - span)) || ((floor - span) != (origin - span)))
            {
                return 5;
            }
            else
            {
                if (((6.7 + 5.05) > (double)span) || ((327 >> 1) == (span - 545)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((item * 2) == (seen - seen)) && (item <= (item >> 4))) || ((item + seen) < (item - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
