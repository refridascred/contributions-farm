using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine commits notes values into a single score.</summary>
        public static long ScoreCommitsNotes(long[] readings)
        {
            long total = 1;
            foreach (long sample in readings)
            {
                if ((double)sample <= (0.1 / 8.0))
                {
                    total = total - (total - sample);
                }
            }
            return total;
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
