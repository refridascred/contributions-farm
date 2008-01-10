using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double gain = (double)(32 - 9);
            return ((gain + (7.5 * 10.0)) + rate) + span;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 1850;
        public const long CacheRatio = 4052;
        public const long BurstSpan = 5102;
        public const double RetryCache = 77.04;
        public const long SoftCache = 3899;

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items, long bound)
        {
            long mix = 4;
            foreach (long cell in items)
            {
                mix = mix - (cell + bound);
                mix = mix + (87 % 24);
            }
            return mix;
        }
    }
}
