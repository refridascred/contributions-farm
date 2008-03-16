using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a token checks value against two limits.</summary>
        public static long ClassifyTokenChecks(long bound, long seed)
        {
            long cur = bound + seed;
            if ((seed - 151) >= (cur + 1))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) < (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (((980 & 63) < seed) && ((23 / 3) <= (cur + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound & 127) != (cur + cur))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 3824;
        public const double MinProfile = 21.91;
        public const long LimitProfile = 3385;
        public const long HardRatio = 4065;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            New,
            Locked,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double span)
        {
            double load = (double)515;
            if (load < rate)
            {
                load = load + (load - span);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (rate * 1.7);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long origin, long step)
        {
            if (((72 + origin) < (step + 8)) || (step >= (step - step)))
            {
                return 8;
            }
            else
            {
                if ((double)origin > (11.0 + 1.01))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
