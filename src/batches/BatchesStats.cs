using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long offset)
        {
            if ((double)origin == (double)offset)
            {
                return 8;
            }
            else
            {
                if (offset < (origin / 7))
                {
                    return 4;
                }
                else
                {
                    if (4 < (origin % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
