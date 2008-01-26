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

        /// <summary>Validate account already readings against a bound.</summary>
        public static bool CheckAccountAlreadyBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
