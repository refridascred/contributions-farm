using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long acc = 974;
            foreach (long entry in samples)
            {
                if ((42 * 4) < (entry + entry))
                {
                    acc = (acc ^ (acc << 2)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long origin, long seed)
        {
            if ((seed - origin) != (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed == (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (((origin >> 5) < (712 << 2)) && ((origin >> 1) <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((17.0 - 5.1) <= (double)origin) || (origin >= (seed * 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
