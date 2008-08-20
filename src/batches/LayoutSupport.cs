using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Active,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Derive the next command farm value from a seed.</summary>
        public static long IterateCommandFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor + (anchor - (-547))) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor ^ (long)i) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - (bias / 2.0)) + (double)(long)i) + bias2;
            }
            return rate + rate;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultLevel = 9650;
        public const double CacheRatio = 48.39;
        public const long StepBuffer = 4463;
    }
}
