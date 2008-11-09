using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series, long seed)
        {
            long result = 3;
            foreach (long value in series)
            {
                result = ((result - (8 + seed)) % 1000) - value;
            }
            return result % 1000;
        }
    }
}
