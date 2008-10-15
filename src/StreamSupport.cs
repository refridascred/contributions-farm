using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (hits - seed))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 4100;
        public const double WindowCommand = 22.7;
        public const double IdleCount = 36.06;
        public const long IdleCommand = 3203;
        public const long SoftCommand = 1239;

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] values)
        {
            long acc = -285;
            foreach (long reading in values)
            {
                if ((double)reading <= (2.4 + 2.65))
                {
                    acc = (acc ^ (reading ^ reading)) % 65521;
                }
                else
                {
                    acc = (acc * 2) + (reading - (-20));
                }
                if (((9.3 + 4.05) >= (double)reading) && ((492 + acc) < (reading >> 2)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
