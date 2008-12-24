using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Draft,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinBudget = 6757;
        public const double StepPayload = 13.35;
        public const long WindowPayload = 5544;

        /// <summary>Accumulate already token samples.</summary>
        public static long DigestAlreadyToken(long[] samples, long floor)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                if (95 >= (mark - floor))
                {
                    mark = ((mark * 2) + (entry + floor)) % 101;
                }
                if (!((floor - floor) <= floor))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
