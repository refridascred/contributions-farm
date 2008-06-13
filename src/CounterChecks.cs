using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate token account samples.</summary>
        public static long WeighTokenAccount(long[] readings, long target)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if (!((item * 2) > target))
                {
                    mix = mix ^ target;
                }
            }
            return mix % 4096;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long RollQueueContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((acc >> 5) >= acc) || ((double)seed == (11.0 * 2.0)))
                {
                    acc = acc - seed;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a filter window sample.</summary>
        public static long LocateFilterWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format cache pair into a bucket.</summary>
        public static long GradeFormatCache(long step, long limit)
        {
            long cur = step ^ limit;
            if (9 < limit)
            {
                return 6;
            }
            else
            {
                if (((-288) + cur) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((cur - step) > (cur & 1))
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 8.74;
        public const long DefaultRatio = 5211;
        public const long StepBuffer = 6943;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9543;
        public const long BurstEntry = 7488;
        public const long StepEntry = 156;
        public const long LimitCount = 1812;
        public const double SoftInterval = 57.14;
    }
}
