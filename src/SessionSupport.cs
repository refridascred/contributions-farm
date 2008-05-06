using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session stats readings against a rule.</summary>
        public static long MeasureSessionStatsMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry * 4) <= (10 * 2))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Find the first tools layout entry that matches the target.</summary>
        public static long FindToolsLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitCount = "strict-edge";
        public const long HardFilter = 9497;
        public const long CacheFactor = 8964;
    }
}
