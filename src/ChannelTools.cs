using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4579;
        public const long BurstCount = 4817;
        public const long CacheFactor = 6647;
        public const string DefaultStats = "stable";
        public const long CacheDepth = 1027;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
