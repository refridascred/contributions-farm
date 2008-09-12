using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            New,
            Stale,
            Retry,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio - floor)) - (double)(long)i;
            }
            return ratio + (double)477;
        }

        /// <summary>Grade a route context value against two limits.</summary>
        public static long RankRouteContext(long seed, long offset)
        {
            long slot = seed + offset;
            if (((double)seed != (6.99 * 20.0)) || ((seed - offset) == (seed / 7)))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) >= offset)
                {
                    return 1;
                }
                else
                {
                    if (offset <= (slot >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long mark = -55;
            foreach (long reading in items)
            {
                if ((mark >> 4) > (33 % 24))
                {
                    mark = (mark + (long)items.Length) + reading;
                }
            }
            return mark % 65521;
        }
    }
}
