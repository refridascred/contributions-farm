using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many buffer support samples are out of range.</summary>
        public static long AuditBufferSupportMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + 6) != (matches - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long offset)
        {
            if (!((step / 3) < (step % 7)))
            {
                return 0;
            }
            else
            {
                if ((5.3 - 4.4) < (double)step)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long StepLayoutBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = carry ^ carry;
                if ((double)step >= (double)carry)
                {
                    carry = ((carry << 3) ^ ((long)i - (long)i)) % 97;
                    carry = (carry ^ (carry >> 5)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
