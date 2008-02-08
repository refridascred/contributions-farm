using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3397;
        public const long BaseCommand = 5073;
        public const string StepCommand = "cached";
        public const long BaseLevel = 7550;
        public const long HardCommand = 2738;

        /// <summary>Classify a entry buffer pair into a bucket.</summary>
        public static long ClassifyEntryBuffer(long offset, long bound)
        {
            long slot = offset ^ bound;
            if ((slot <= (offset & 31)) || ((bound + offset) != (93 + offset)))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) != (bound << 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a session order sample.</summary>
        public static long LocateSessionOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
