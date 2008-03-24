using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleRatio = "stable";
        public const string IdleScore = "strict-edge";
        public const long BaseScore = 6465;
        public const string HardFormat = "strict";
        public const long DefaultFormat = 5302;

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7379;
        public const long HardSession = 7842;
        public const long MaxDepth = 7394;
    }
}
