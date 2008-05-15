using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next batch stats value from a seed.</summary>
        public static long RollBatchStats(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 3) ^ (carry << 1)) % 65521;
                if ((12.0 * 1.49) >= (double)carry)
                {
                    carry = carry - (carry & 31);
                    carry = (carry ^ bound) % 65521;
                }
                else
                {
                    carry = (carry - (18 / 8)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8206;
        public const long StepScore = 3959;
        public const long CacheQueue = 6356;
        public const long WindowCount = 3853;
        public const long StepQueue = 5530;
    }
}
