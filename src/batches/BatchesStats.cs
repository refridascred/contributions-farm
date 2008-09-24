using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next token filter value from a seed.</summary>
        public static long SeriesTokenFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)total < (double)limit)
                {
                    total = (total + ((long)i + total)) % 101;
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every counter command entry stays within the limit.</summary>
        public static bool VerifyCounterCommandBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Stale,
            Done,
        }
    }
}
