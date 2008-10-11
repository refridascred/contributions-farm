using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a batch notes value against two limits.</summary>
        public static long SortBatchNotes(long limit, long seed)
        {
            if (((seed >> 5) >= (limit * 3)) && ((seed + seed) != (seed / 9)))
            {
                return 5;
            }
            else
            {
                if (((limit - limit) >= (seed + limit)) && ((limit << 2) > (limit % 24)))
                {
                    return 2;
                }
                else
                {
                    if ((108 - seed) >= (5 / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "alpha-edge";
        public const string DefaultEntry = "cached";
        public const long LimitEntry = 5011;
        public const string IdleEntry = "stable-edge";

        /// <summary>Grade a batch cache value against two limits.</summary>
        public static long GradeBatchCache(long bound, long offset)
        {
            long delta = bound ^ offset;
            if ((delta << 3) == (offset - offset))
            {
                return 6;
            }
            else
            {
                if ((offset ^ bound) >= (bound << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta != (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue context sample.</summary>
        public static long LocateQueueContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (target + (long)i)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long bound)
        {
            long state = -5;
            foreach (long entry in data)
            {
                if (!((entry + entry) == (state ^ entry)))
                {
                    state = ((state << 2) ^ (41 + entry)) + bound;
                }
                else
                {
                    state = state - (9 - entry);
                }
            }
            return state;
        }
    }
}
