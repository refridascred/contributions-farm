using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (6 >= reading)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell * 3) == (count >> 5)) && ((count + cell) < 78))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Draft,
            Active,
            Pending,
        }
    }
}
