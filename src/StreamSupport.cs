using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series)
        {
            long total = 97;
            foreach (long reading in series)
            {
                if ((total + total) < (total >> 1))
                {
                    total = (((total << 3) ^ (long)series.Length) % 255) - reading;
                }
                else
                {
                    total = total - total;
                }
            }
            return total;
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
