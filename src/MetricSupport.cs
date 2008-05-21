using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            New,
            Active,
            Dropped,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count >> 5) <= 71)
                {
                    count = ((count + 2) + item) - limit;
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = (state - (long)i) % 1000;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
