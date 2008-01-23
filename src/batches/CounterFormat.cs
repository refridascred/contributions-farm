using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((8.2 - 2.8) >= (double)value) && ((value << 3) >= (hits >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long step)
        {
            long cur = bound - step;
            if (step <= (bound << 3))
            {
                return 5;
            }
            else
            {
                if (((double)step == (8.0 - 7.76)) && ((cur >> 4) <= (74 << 1)))
                {
                    return 1;
                }
                else
                {
                    if ((double)cur > (3.0 + 3.33))
                    {
                        return 6;
                    }
                    else
                    {
                        if (9.33 > (double)cur)
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
        }
    }
}
