using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long step)
        {
            long slot = floor ^ step;
            if ((double)slot == (7.96 * 6.1))
            {
                return 2;
            }
            else
            {
                if ((floor << 2) >= (step >> 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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
