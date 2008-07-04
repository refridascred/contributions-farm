using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowSpan = 1681;
        public const long MaxTimeout = 1947;
        public const long LimitCache = 2924;
        public const long IdleFactor = 9698;
        public const long BaseSize = 268;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Ready,
            Pending,
        }
    }
}
