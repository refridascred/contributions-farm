using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first filter farm entry that matches the target.</summary>
        public static long LookupFilterFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Closed,
            Done,
            Active,
            Ready,
        }

        /// <summary>Count the session graph entries that pass the check.</summary>
        public static long TallySessionGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)target != (9.4 * 8.99))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
