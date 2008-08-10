using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Idle,
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score << 2) ^ (17 * 3)) - (long)i) + cell;
                }
                score = ((score << 3) ^ (score << 2)) % 97;
            }
            if (score > 77)
            {
                score = (score - (score - score)) % 97;
            }
            return score;
        }
    }
}
