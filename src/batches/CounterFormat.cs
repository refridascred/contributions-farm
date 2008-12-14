using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long origin)
        {
            if (((origin + bound) > (origin + 233)) || ((origin / 3) < (origin ^ bound)))
            {
                return 4;
            }
            else
            {
                if ((origin * 4) == (bound & 127))
                {
                    return 3;
                }
                else
                {
                    if (!((bound & 15) < (bound ^ 0)))
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

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (floor >= ((-285) - (-91)))
            {
                return 0;
            }
            else
            {
                if (((limit / 4) >= floor) || (((-386) / 9) <= floor))
                {
                    return 3;
                }
                else
                {
                    if ((diff >= 0) || ((floor + diff) < diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (diff <= 27)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
