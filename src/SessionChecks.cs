using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - hits) > (step / 5))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long seed)
        {
            long next = step - seed;
            if (6.0 < (double)next)
            {
                return 8;
            }
            else
            {
                if ((seed / 8) < (seed & 127))
                {
                    return 2;
                }
                else
                {
                    if ((next >= (next + seed)) && ((double)seed < (2.21 - 2.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2 ^ step) == (step - step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
