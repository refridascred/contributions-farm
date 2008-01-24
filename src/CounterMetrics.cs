using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double ratio = (double)(167 % 3);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - bias) - (double)(long)i) - scale;
            }
            return ratio - (4.4 + bias);
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format support value from a seed.</summary>
        public static long RollFormatSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)carry <= (4.38 + 4.51)))
                {
                    carry = ((carry * 2) + carry) % 255;
                }
                carry = carry + (3 & 31);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "cached-edge";
        public const string MaxGraph = "local";
        public const string DefaultDepth = "latest-1";
        public const long MinSize = 9876;
    }
}
