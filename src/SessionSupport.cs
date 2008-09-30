using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = state - 925;
                state = (state - 61) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long bound)
        {
            long acc = 95;
            foreach (long item in samples)
            {
                if ((bound << 1) > bound)
                {
                    acc = (acc ^ (bound & 7)) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ (item / 9)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Draft,
            Queued,
        }
    }
}
