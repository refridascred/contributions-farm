using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a farm buffer counter forward.</summary>
        public static long IterateFarmBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit % 10) < limit)
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleFactor = "legacy";
        public const double LimitPayload = 5.98;
        public const string IdleWidth = "latest-1";
        public const string MaxPayload = "strict-v2";
        public const string WindowPayload = "standard";

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                if (678 >= (target ^ target))
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long origin)
        {
            if ((double)origin >= (7.89 + 7.9))
            {
                return 2;
            }
            else
            {
                if (!((origin ^ origin) < step))
                {
                    return 0;
                }
                else
                {
                    if ((double)step < (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
