using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] values)
        {
            long sum = 84;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (((sum * 4) + (sum % 2)) % 1000) + (long)i;
                }
                sum = ((sum << 2) ^ (reading + reading)) % 255;
                sum = (sum + (sum ^ sum)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many checks editor samples are out of range.</summary>
        public static long AuditChecksEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (18.0 * 1.16))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }
    }
}
