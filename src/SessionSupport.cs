using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell / 2) >= matches) || (((matches >> 4) != (cell + matches)) && ((matches - matches) == (cell - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Synced,
            Paused,
            Active,
        }
    }
}
