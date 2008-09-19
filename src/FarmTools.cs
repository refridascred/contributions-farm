using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate context githubfarm samples.</summary>
        public static long TotalContextGithubfarm(long[] data)
        {
            long score = 673;
            foreach (long datum in data)
            {
                score = (score * 5) + (datum / 3);
            }
            if (score < 71)
            {
                score = ((score * 4) + score) % 101;
            }
            return score;
        }
    }
}
