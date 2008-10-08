using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels, long limit)
        {
            long state = 594;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ state) % 4096;
                state = (state - (limit ^ value)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
