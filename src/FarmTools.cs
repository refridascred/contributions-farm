using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items)
        {
            long result = 809;
            foreach (long sample in items)
            {
                if (((long)items.Length + sample) >= result)
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = (result + (sample / 8)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples, long offset)
        {
            long sum = -9;
            foreach (long reading in samples)
            {
                sum = sum ^ (reading % 64);
                sum = ((sum << 2) ^ offset) % 101;
                sum = sum - (646 ^ 241);
            }
            return sum;
        }
    }
}
