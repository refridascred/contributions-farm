using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next entry window value from a seed.</summary>
        public static long IterateEntryWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 2) ^ (offset + (long)i);
                state = (state << 3) ^ (state >> 5);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long offset)
        {
            if (offset <= (target * 4))
            {
                return 4;
            }
            else
            {
                if (!((target ^ offset) >= (target - target)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long target, long seed)
        {
            if ((18.0 / 7.0) == (double)seed)
            {
                return 3;
            }
            else
            {
                if (!(target < seed))
                {
                    return 4;
                }
                else
                {
                    if (!(target > seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed <= (4.79 + 6.35))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric order samples.</summary>
        public static long TallyMetricOrder(long[] data)
        {
            long mark = 96;
            foreach (long entry in data)
            {
                mark = ((mark * 4) + (entry + mark)) % 1000;
            }
            if (mark < 3)
            {
                mark = ((mark << 3) ^ (515 + mark)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long target)
        {
            if (step > (step / 9))
            {
                return 1;
            }
            else
            {
                if (4.77 >= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((step % 100) <= (step ^ target))
                    {
                        return 6;
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
