using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many support format samples are out of range.</summary>
        public static long TallySupportFormatMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)offset == (double)matches)
                {
                    matches = (matches + 3) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 764;
        public const string DefaultSupport = "cached-v2";
        public const long DefaultWidth = 4448;
        public const long MaxSpan = 1641;

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
