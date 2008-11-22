using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of format schema readings.</summary>
        public static long FoldFormatSchema(long[] values, long limit)
        {
            long result = 6;
            foreach (long entry in values)
            {
                if ((6.34 - 18.0) == (double)result)
                {
                    result = (((result << 3) ^ entry) % 97) + limit;
                }
                result = (result * 4) + (result + entry);
            }
            return result;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] samples, long target)
        {
            long carry = 28;
            foreach (long sample in samples)
            {
                carry = ((carry - (sample - carry)) % 255) + target;
            }
            return carry;
        }
    }
}
