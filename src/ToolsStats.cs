using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Classify a report graph pair into a bucket.</summary>
        public static long RankReportGraph(long seed, long bound)
        {
            if ((bound / 5) < bound)
            {
                return 0;
            }
            else
            {
                if ((double)bound < (0.77 / 5.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen + item) < (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double scale = offset;
            if (scale < (offset - offset))
            {
                scale = scale + scale;
            }
            return scale + (ratio / 4.0);
        }

        /// <summary>Iterate the report context series from a seed.</summary>
        public static long DeriveReportContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = (state - 1) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
