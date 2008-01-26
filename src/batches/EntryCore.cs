using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long target)
        {
            long carry = 359;
            foreach (long sample in series)
            {
                carry = (carry + sample) % 65521;
            }
            if (carry < 10)
            {
                carry = ((carry * 4) + (target + 85)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a cluster channel sample.</summary>
        public static long FindClusterChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a context payload pair into a bucket.</summary>
        public static long SortContextPayload(long target, long target2)
        {
            long slot = target + target2;
            if (!(85 >= (8 + slot)))
            {
                return 4;
            }
            else
            {
                if ((slot >> 1) == (target2 >> 1))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
