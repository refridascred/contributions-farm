using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((7.86 * 19.0) < (double)value)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((92 ^ offset) > (offset >> 5))
                {
                    carry = (carry + (offset / 9)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
