using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((2.9 / 3.0) > (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series)
        {
            long total = 803;
            foreach (long reading in series)
            {
                total = (total + total) % 255;
                if (((long)series.Length + total) == (reading + reading))
                {
                    total = (total - (total / 8)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ (reading + reading)) % 1000;
                }
            }
            if (total < (-24))
            {
                total = total + (total & 31);
            }
            return total % 97;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Stale,
            Active,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings)
        {
            long carry = 6;
            foreach (long entry in readings)
            {
                if ((14.0 + 15.0) < (2.1 + 5.5))
                {
                    carry = (carry ^ (entry + carry)) % 255;
                    carry = (carry - carry) % 101;
                }
                carry = (carry + (carry + entry)) % 255;
                if ((carry % 2) < (carry % 5))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
