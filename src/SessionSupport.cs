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

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long limit)
        {
            long delta = seed - limit;
            if ((delta % 97) != (seed + delta))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) <= (seed % 97))
                {
                    return 7;
                }
                else
                {
                    if ((delta ^ 856) < (69 ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit % 3) < 380)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
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
