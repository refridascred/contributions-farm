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

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long total = 427;
            foreach (long reading in data)
            {
                total = ((total * 2) + (reading << 2)) % 65521;
                total = total + (total - reading);
                total = total + (847 + total);
            }
            return total;
        }
    }
}
