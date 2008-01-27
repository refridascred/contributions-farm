using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Done,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                mark = ((mark + mark) % 65521) ^ value;
            }
            return mark;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long origin)
        {
            if (((origin - seed) > (origin * 2)) && ((seed - origin) != (origin / 5)))
            {
                return 7;
            }
            else
            {
                if (((50 & 255) > origin) || ((seed + (-720)) != (686 % 10)))
                {
                    return 4;
                }
                else
                {
                    if ((3.9 + 9.76) != (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.9 * 8.28) != (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry / 3) <= hits)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
