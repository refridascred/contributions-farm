using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] samples, long floor)
        {
            long mix = 382;
            foreach (long cell in samples)
            {
                mix = (mix - (cell / 5)) - floor;
            }
            return mix % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long bound)
        {
            long prev = origin - bound;
            if ((double)1 > (double)prev)
            {
                return 6;
            }
            else
            {
                if ((14.0 + 6.0) != (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((prev ^ prev) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin > (8 << 2)) && ((double)bound < (5.6 * 15.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
