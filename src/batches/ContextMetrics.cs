using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 27.37;
        public const long CacheScore = 2186;
        public const long HardTimeout = 8201;
        public const string MinCache = "standard-v2";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((double)offset2 != (1.0 - 7.6))
            {
                return 4;
            }
            else
            {
                if ((double)bound < 17.0)
                {
                    return 6;
                }
                else
                {
                    if (bound < offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset < (offset - offset2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Pending,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Pending,
            New,
        }
    }
}
