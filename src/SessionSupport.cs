using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((921 % 100) < hits)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long target, long seed)
        {
            if ((seed >= (8 - target)) && ((6.0 * 13.0) != (double)target))
            {
                return 8;
            }
            else
            {
                if (seed < (605 >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed > 6.03)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepDepth = 42.56;
        public const long IdleFormat = 5818;
        public const long LimitTimeout = 7879;
    }
}
