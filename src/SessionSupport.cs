using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardWidth = 1405;
        public const long HardRecord = 8291;
        public const string WindowRatio = "latest-1";

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
