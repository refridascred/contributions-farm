using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count tools account pairs that satisfy a relation.</summary>
        public static long OverlapToolsAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBudget = 5990;
        public const long StepCount = 5548;
        public const long SoftBatch = 9397;
        public const string BaseDepth = "local-edge";
        public const long BaseBatch = 8715;
    }
}
