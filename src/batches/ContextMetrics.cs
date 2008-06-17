using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardSpan = "open-edge";
        public const double MaxBudget = 78.64;
        public const long HardTimeout = 4680;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches >= (double)value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cluster command sample.</summary>
        public static long LookupClusterCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Count the payload cluster entries that pass the check.</summary>
        public static long TallyPayloadClusterGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (88 >= floor)
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
