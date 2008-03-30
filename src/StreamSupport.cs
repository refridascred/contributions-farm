using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series)
        {
            long carry = 775;
            foreach (long entry in series)
            {
                if ((996 - carry) < (2 / 9))
                {
                    carry = carry - carry;
                }
                if (entry <= (entry << 3))
                {
                    carry = carry - (entry ^ entry);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Draft,
            Failed,
            Pending,
            Done,
        }
    }
}
