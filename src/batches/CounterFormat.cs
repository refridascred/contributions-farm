using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            New,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Count the support report entries that pass the check.</summary>
        public static long TallySupportReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((entry + hits) < hits) && (entry >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
