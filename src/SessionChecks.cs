using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double span)
        {
            double load = rate * 5.12;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (double)(long)i) - span;
            }
            return load + (double)10;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 9740;
        public const string BaseCommand = "alpha-edge";
        public const long MaxRatio = 3860;
        public const long BaseRatio = 541;

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
