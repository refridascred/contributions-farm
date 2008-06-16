using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(((4.06 + 4.0) < (double)origin) && ((3.2 / 6.0) >= (double)seen)))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (1.0 <= (double)tally)
                {
                    tally = ((tally + 1) + entry) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data, long origin)
        {
            long score = -80;
            foreach (long item in data)
            {
                if (score > (score >> 5))
                {
                    score = ((score + score) + item) + origin;
                }
            }
            return score % 4096;
        }
    }
}
