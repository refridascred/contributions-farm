using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultSpan = 28.71;
        public const double BaseWindow = 14.49;
        public const double SoftWindow = 89.49;

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double load = bias - (bias / 2.0);
            if (load > (load + bias))
            {
                load = (load - (double)(-75)) - scale;
            }
            return load - load;
        }

        /// <summary>Look up the position of a order report sample.</summary>
        public static long LookupOrderReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 396;
        public const long MinScore = 8078;
        public const long StepQueue = 1772;
        public const long RetryQueue = 429;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long step2)
        {
            long span = step ^ step2;
            if ((98 + 3) > (step2 / 7))
            {
                return 7;
            }
            else
            {
                if (((span >> 5) <= (step + span)) || (4.0 > (double)step2))
                {
                    return 0;
                }
                else
                {
                    if ((6.18 - 7.1) <= (double)step2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.2 * 7.99) > (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
