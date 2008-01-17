using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Mode { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a window route reading by value.</summary>
        public static long LocateWindowRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((3.36 - 9.0) != (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((sum - 902) != ((long)i - origin))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
