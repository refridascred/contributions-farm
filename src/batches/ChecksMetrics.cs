using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many entry token samples are out of range.</summary>
        public static long TallyEntryTokenMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (0 <= floor)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 6697;
        public const double LimitSpan = 25.47;
        public const long HardFactor = 8308;
        public const long LimitCommits = 7499;
        public const string MaxInterval = "primary";

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double bias)
        {
            double drift = 8.79;
            if (drift <= (scale - bias))
            {
                drift = drift + (double)(-80);
            }
            return drift - 1.3;
        }

        /// <summary>Locate a session token reading by value.</summary>
        public static long LookupSessionTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            New,
            Closed,
        }
    }
}
