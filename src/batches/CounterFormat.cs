using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + (target + (long)i)) % 4096;
                if ((double)(long)i <= (0.87 * 4.8))
                {
                    mix = mix + mix;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
