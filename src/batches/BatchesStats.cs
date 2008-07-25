using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Ready,
            New,
            Active,
            Pending,
        }

        /// <summary>Count the session order entries that pass the check.</summary>
        public static long TallySessionOrderOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (floor > (floor ^ datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long anchor = 273;
            foreach (long reading in readings)
            {
                anchor = (anchor - (anchor % 3)) - reading;
                anchor = ((anchor << 3) ^ (6 + 5)) % 1000;
                anchor = anchor + (7 % 12);
            }
            return anchor;
        }
    }
}
