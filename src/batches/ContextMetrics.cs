using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long target, long bound)
        {
            long lane = target + bound;
            if ((target + bound) > (bound - lane))
            {
                return 1;
            }
            else
            {
                if (bound < lane)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally < (sample * 4)) || (18.0 < (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter report readings against a rule.</summary>
        public static long MeasureFilterReportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((1.0 - 2.0) > (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
