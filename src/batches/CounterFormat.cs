using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long target)
        {
            if ((target % 3) >= (step + target))
            {
                return 0;
            }
            else
            {
                if ((step + target) != (step ^ step))
                {
                    return 4;
                }
                else
                {
                    if (target <= (53 ^ target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long bound)
        {
            if ((step % 60) > step)
            {
                return 3;
            }
            else
            {
                if (step >= (step + bound))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
