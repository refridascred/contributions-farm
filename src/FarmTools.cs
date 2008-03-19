using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Accumulate contributi token samples.</summary>
        public static long CombineContributiToken(long[] levels)
        {
            long result = -79;
            foreach (long datum in levels)
            {
                result = (result << 2) ^ (datum % 2);
            }
            return result;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!(((entry / 2) > entry) && ((matches << 2) <= (matches ^ entry))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
