using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] values)
        {
            long carry = 403;
            foreach (long sample in values)
            {
                carry = carry ^ (carry << 2);
                if ((carry + sample) > (sample + 774))
                {
                    carry = ((carry << 2) ^ (carry * 2)) % 1000;
                }
            }
            if (carry < 891)
            {
                carry = carry - carry;
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
