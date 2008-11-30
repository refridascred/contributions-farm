using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the queue tools entries that pass the check.</summary>
        public static long TallyQueueToolsHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((5.21 + 8.4) > (double)tally) && ((double)value == (8.0 - 19.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 8185;
        public const double BatchLayout = 32.7;
        public const long BatchLevel = 3846;
        public const long MaxLayout = 3273;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                mark = (mark + origin) + entry;
            }
            return mark;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
