using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches / 4) == (entry ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen - (long)readings.Length) > seen)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Validate farm buffer readings against a bound.</summary>
        public static bool ValidateFarmBufferBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the githubfarm channel series from a seed.</summary>
        public static long SeriesGithubfarmChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 3) ^ ((long)i >> 4);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item <= (item - item)) && !((item + item) <= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
