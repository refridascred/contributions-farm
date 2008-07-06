using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Failed,
            New,
            Paused,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Retry,
            Pending,
            Failed,
            New,
            Draft,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long origin)
        {
            long diff = target ^ origin;
            if (((origin - origin) <= ((-92) + target)) || (origin >= 4))
            {
                return 6;
            }
            else
            {
                if ((diff & 15) > (-164))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
