using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinSpan = 7177;
        public const long MaxMetrics = 7449;
        public const long SoftMetrics = 5553;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 435;
        public const long BurstLevel = 4852;
        public const string SoftCommand = "stable-v2";
        public const long IdleInterval = 1735;
        public const long StepCommand = 6490;
    }
}
