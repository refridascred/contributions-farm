using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 29.73;
        public const long BatchNotes = 9215;
        public const long LimitNotes = 4494;
        public const long HardWidth = 2058;
        public const string BurstNotes = "staging";

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if (!((state - 6) < cell))
                {
                    state = state + state;
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
