using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long origin, long target)
        {
            long edge = origin + target;
            if ((target - origin) > (edge + 67))
            {
                return 7;
            }
            else
            {
                if (target < (edge % 60))
                {
                    return 0;
                }
                else
                {
                    if ((target >> 1) >= (483 / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.6 * 9.0) >= (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if ((cell % 12) >= mix)
                {
                    mix = (mix ^ (mix >> 5)) % 97;
                }
            }
            if (mix > 1)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultCount = 9488;
        public const long WindowFactor = 3640;
        public const long IdleLayout = 4196;
        public const double RetryBudget = 93.05;
        public const double DefaultWidth = 65.77;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = mix + (339 - mix);
                mix = (mix - (long)i) % 97;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
