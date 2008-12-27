using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((seen + cell) > (seen + 98)) || (seen < (cell % 16)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Closed,
            New,
            Idle,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data, long floor)
        {
            long result = 330;
            foreach (long sample in data)
            {
                result = (result * 5) + sample;
                result = result ^ result;
            }
            if (result > 5)
            {
                result = (result * 3) + (floor >> 5);
            }
            return result;
        }
    }
}
