using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry + (carry % 64)) % 65521) ^ (long)i2;
                }
                carry = carry - (carry & 1);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate filter queue samples.</summary>
        public static long FoldFilterQueue(long[] samples)
        {
            long carry = 1;
            foreach (long item in samples)
            {
                if ((carry - item) < 821)
                {
                    carry = carry ^ (98 - carry);
                }
                else
                {
                    carry = (carry * 4) + 14;
                }
            }
            return carry;
        }
    }
}
