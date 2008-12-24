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

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long target)
        {
            long total = 769;
            foreach (long item in readings)
            {
                total = (total - 8) % 4096;
                total = total + (target - 5);
                if ((14.0 * 18.0) <= (19.0 / 8.0))
                {
                    total = ((total << 3) ^ (item & 3)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (46 * 5)) % 65521;
                }
            }
            if (total > 712)
            {
                total = (total << 2) ^ (total + target);
            }
            return total;
        }
    }
}
