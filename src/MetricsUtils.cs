using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)value <= 2.0))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long score = 2;
            foreach (long reading in readings)
            {
                score = ((score ^ (score - score)) % 1000) ^ reading;
            }
            if (score < 306)
            {
                score = ((score * 4) + score) % 97;
            }
            return score;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue notes value from a seed.</summary>
        public static long SeriesQueueNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
