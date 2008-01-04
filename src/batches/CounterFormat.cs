using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long offset)
        {
            long total = -65;
            foreach (long reading in levels)
            {
                if (offset > (total << 1))
                {
                    total = (total << 3) ^ (offset ^ offset);
                }
                else
                {
                    total = (total << 2) ^ (offset - reading);
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels)
        {
            long sum = 761;
            foreach (long item in levels)
            {
                if ((item << 3) < item)
                {
                    sum = (sum - (32 * 4)) % 1000;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (sum ^ sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
