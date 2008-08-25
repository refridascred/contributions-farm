using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Failed,
            New,
            Retry,
        }

        /// <summary>Count counter order pairs that satisfy a relation.</summary>
        public static long CompareCounterOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Stale,
            New,
            Active,
        }
    }
}
