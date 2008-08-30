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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long bound)
        {
            long next = offset ^ bound;
            if ((double)next == (14.0 - 8.3))
            {
                return 0;
            }
            else
            {
                if (!((next ^ offset) <= (next & 7)))
                {
                    return 3;
                }
                else
                {
                    if ((bound + offset) < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 4763;
        public const double HardCount = 7.79;
        public const double CacheWindow = 90.06;
        public const long CacheInterval = 5;
        public const long LimitWindow = 3131;

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
