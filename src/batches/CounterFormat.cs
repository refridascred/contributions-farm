using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)entry == (2.32 * 4.74))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long TallyWindowEditorGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((8 + datum) > (hits / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc >> 2);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
