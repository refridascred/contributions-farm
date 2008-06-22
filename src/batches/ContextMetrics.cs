using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Pending,
            New,
            Draft,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item >> 1) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long step2)
        {
            if ((10.0 * 9.5) >= (double)step2)
            {
                return 2;
            }
            else
            {
                if (step < (step & 1))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
