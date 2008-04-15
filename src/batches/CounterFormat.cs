using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream graph samples are out of range.</summary>
        public static long TallyStreamGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches <= (8.4 - 7.15))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
