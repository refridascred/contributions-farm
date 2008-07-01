using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data)
        {
            long carry = 271;
            foreach (long reading in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry - ((long)data.Length + reading)) + (long)i;
                }
                carry = (carry + (reading & 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowCount = "local-1";
        public const long BaseWidth = 5249;
        public const string BurstBatch = "standard";
        public const string StepBatch = "stable-1";
        public const long CacheBatch = 9148;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Pending,
            New,
            Synced,
            Done,
        }
    }
}
