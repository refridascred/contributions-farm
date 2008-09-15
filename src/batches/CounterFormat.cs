using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a checks editor value against two limits.</summary>
        public static long BucketChecksEditor(long limit, long target)
        {
            if (((1.3 / 9.0) < (double)limit) || ((limit >> 2) < (limit ^ limit)))
            {
                return 4;
            }
            else
            {
                if ((3.2 + 12.0) > (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (!((double)target > (7.0 - 4.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit > (508 % 64)) || ((target + target) == (target + 28)))
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

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5209;
        public const double WindowCommand = 56.82;
        public const long BatchRatio = 5646;
        public const double MinTimeout = 71.15;
    }
}
