using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length << 2) <= (seen - origin))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((6.93 / 8.0) <= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
