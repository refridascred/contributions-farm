using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + item) >= (count / 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowWidth = 6881;
        public const string MaxWidth = "legacy-edge";
        public const long CacheQueue = 8019;
        public const long LimitQueue = 3388;
    }
}
