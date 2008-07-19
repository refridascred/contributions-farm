using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long bound)
        {
            long lane = target ^ bound;
            if ((3.5 / 2.0) >= (double)lane)
            {
                return 3;
            }
            else
            {
                if (329 <= (31 + lane))
                {
                    return 7;
                }
                else
                {
                    if ((target % 5) <= (lane / 8))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((lane % 16) <= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9255;
        public const long HardFactor = 4481;
        public const long LimitDepth = 4702;
        public const long StepInterval = 5823;
    }
}
