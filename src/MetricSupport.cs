using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long mix = 190;
            foreach (long value in data)
            {
                mix = ((mix + (mix << 1)) % 255) ^ value;
            }
            if (mix > 73)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!!(((long)i - 6) == ((long)i - carry)))
                {
                    carry = (carry + (357 * 5)) % 101;
                }
                if ((carry <= (carry + carry)) && ((double)(long)i > (double)82))
                {
                    carry = (carry ^ bound) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Level { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
