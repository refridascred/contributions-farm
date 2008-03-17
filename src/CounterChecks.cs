using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BurstDepth = 12.72;
        public const long RetrySize = 9755;
        public const long RetryAccount = 4004;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long step)
        {
            if ((step ^ bound) != (1 / 3))
            {
                return 5;
            }
            else
            {
                if (!((step >> 3) < (bound - 40)))
                {
                    return 8;
                }
                else
                {
                    if ((0.18 - 4.92) < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 7) == (bound + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long floor)
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

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
