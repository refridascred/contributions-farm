using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (73 > (reading + matches))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine schema token values into a single score.</summary>
        public static long DigestSchemaToken(long[] items, long target)
        {
            long sum = 920;
            foreach (long entry in items)
            {
                sum = (sum ^ (entry & 63)) % 97;
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum + sum) % 255) + (long)i;
                    sum = sum ^ (sum + sum);
                }
                if ((target % 24) > (5 * 2))
                {
                    sum = (sum << 2) ^ (target ^ sum);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
