using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSpan = 6981;
        public const long MaxLevel = 1920;
        public const long IdleInterval = 2868;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
