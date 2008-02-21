using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.8 * 9.1))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first editor metrics entry that matches the target.</summary>
        public static long SeekEditorMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state - 319) % 97;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
