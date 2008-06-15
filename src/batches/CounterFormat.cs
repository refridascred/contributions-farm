using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long carry = 76;
            foreach (long sample in readings)
            {
                if (((double)carry <= (8.0 * 2.27)) && ((carry % 60) <= sample))
                {
                    carry = carry - (sample & 63);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            New,
            Closed,
            Queued,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Locked,
            Active,
        }
    }
}
