using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSize = 3601;
        public const double BatchPayload = 52.23;
        public const double SoftPayload = 95.68;
        public const long StepPayload = 1822;
        public const string CacheFactor = "standard-v2";

        /// <summary>Accumulate editor batches samples.</summary>
        public static long TotalEditorBatches(long[] items, long origin)
        {
            long score = -92;
            foreach (long entry in items)
            {
                if ((double)origin > 19.0)
                {
                    score = (((score * 2) + (origin - 5)) % 255) ^ entry;
                }
                else
                {
                    score = score + (origin << 1);
                }
            }
            return score;
        }
    }
}
