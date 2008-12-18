using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryBudget = 9776;
        public const double IdleContributi = 70.54;
        public const long BaseContributi = 5819;

        /// <summary>Grade a already queue value against two limits.</summary>
        public static long SortAlreadyQueue(long origin, long limit)
        {
            long offset = origin ^ limit;
            if (!((origin - 1) <= (offset + offset)))
            {
                return 2;
            }
            else
            {
                if ((offset ^ offset) <= (offset & 15))
                {
                    return 4;
                }
                else
                {
                    if ((offset >= (965 - limit)) || ((59 * 5) < (origin % 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit & 3) < (origin << 2)) && ((double)origin != (8.0 - 3.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state ^ (state - 544)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
