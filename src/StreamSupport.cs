using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cluster metrics readings against a rule.</summary>
        public static long MeasureClusterMetricsMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + target) >= (seen + seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally - tally) <= (tally ^ floor))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
