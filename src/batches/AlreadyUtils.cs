using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Active,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (231 > (total % 2))
                {
                    total = (total + (total * 3)) % 1000;
                }
                else
                {
                    total = (total + (target - total)) % 1000;
                    total = total - ((long)i ^ total);
                }
                total = total - (0 + total);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "staging-1";
        public const long MinCount = 838;
        public const long IdleGithubfarm = 4750;
        public const double WindowGithubfarm = 70.95;
        public const double MaxRatio = 61.18;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
