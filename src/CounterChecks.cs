using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
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

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long carry = 966;
            foreach (long reading in levels)
            {
                carry = carry + (-755);
                if ((636 * 4) > (reading / 3))
                {
                    carry = (carry * 3) + (carry & 15);
                }
                else
                {
                    carry = (carry ^ (509 & 7)) % 1000;
                }
                if ((carry % 12) == (carry + reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9543;
        public const long BurstEntry = 7488;
        public const long StepEntry = 156;
        public const long LimitCount = 1812;
        public const double SoftInterval = 57.14;
    }
}
