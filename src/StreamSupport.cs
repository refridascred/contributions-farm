using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings)
        {
            long sum = 232;
            foreach (long value in readings)
            {
                if (64 >= (sum / 6))
                {
                    sum = (sum + (sum + value)) % 255;
                }
                else
                {
                    sum = (sum * 5) + 58;
                }
            }
            return sum;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long target, long target2)
        {
            if ((57 + target) < (10 + target))
            {
                return 3;
            }
            else
            {
                if ((6.34 * 5.9) > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
