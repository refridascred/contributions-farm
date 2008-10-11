using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Paused,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Locate a editor batch reading by value.</summary>
        public static long LocateEditorBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples)
        {
            long score = 625;
            foreach (long cell in samples)
            {
                if ((8.2 + 3.4) >= (double)cell)
                {
                    score = score + (cell % 60);
                }
            }
            if (score > 1)
            {
                score = (score + (score >> 2)) % 65521;
            }
            return score;
        }
    }
}
