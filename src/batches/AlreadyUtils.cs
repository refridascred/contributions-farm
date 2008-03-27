using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long acc = 5;
            foreach (long value in values)
            {
                acc = (acc + (value - acc)) % 255;
            }
            if (acc < 16)
            {
                acc = (acc ^ (acc << 1)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] series, long target)
        {
            long anchor = 18;
            foreach (long datum in series)
            {
                anchor = (anchor ^ datum) % 97;
                if ((datum / 7) < (datum * 2))
                {
                    anchor = ((anchor << 2) ^ (target << 1)) % 4096;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
            }
            if (anchor < 59)
            {
                anchor = (anchor * 2) + (target - anchor);
            }
            return anchor;
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
