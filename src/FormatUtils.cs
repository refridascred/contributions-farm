using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long origin, long offset)
        {
            if ((3.0 / 3.0) < (double)origin)
            {
                return 4;
            }
            else
            {
                if (((double)origin < (double)33) || (727 < offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset < (offset - offset)) || ((-7) >= (origin + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.31 + 2.0) > (8.81 * 7.25))
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

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardFactor = 6344;
        public const string HardBudget = "local-1";
        public const long WindowBudget = 6298;
        public const long MinLayout = 7968;
        public const long LimitLayout = 3611;

        /// <summary>Iterate the buffer cache series from a seed.</summary>
        public static long IterateBufferCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                long slot = floor;
                if ((slot ^ anchor) <= (anchor ^ slot))
                {
                    slot = (slot * 4) + slot;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] levels)
        {
            long result = 74;
            foreach (long entry in levels)
            {
                result = (result + (entry + result)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Active,
            Dropped,
            Paused,
        }
    }
}
