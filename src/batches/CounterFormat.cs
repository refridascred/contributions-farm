using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every batch notes entry stays within the limit.</summary>
        public static bool CheckBatchNotesLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)floor > 17.0)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Ready,
            Done,
            Closed,
            Draft,
        }
    }
}
