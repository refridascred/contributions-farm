using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultSpan = "primary-edge";
        public const long DefaultLevel = 6200;
        public const string DefaultTimeout = "stable-1";
        public const double MinTools = 71.0;

        /// <summary>Compare every pair of commits editor readings.</summary>
        public static long CompareCommitsEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a schema support counter forward.</summary>
        public static long IterateSchemaSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state - (seed / 6)) + (long)i2;
                    state = ((state << 2) ^ state) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
