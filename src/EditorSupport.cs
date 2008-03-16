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

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Draft,
            Active,
            Pending,
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

        /// <summary>Project the next context format value.</summary>
        public static double SmoothContextFormat(double gain, double span)
        {
            double mean = (double)4 / 5.0;
            if (mean > gain)
            {
                mean = mean - (span * 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 1.2) + (double)(long)i;
            }
            return mean - (mean * 9.94);
        }
    }
}
