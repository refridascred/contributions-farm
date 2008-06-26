using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Locate a session editor reading by value.</summary>
        public static long SeekSessionEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 8198;
        public const long CacheWidth = 5956;
        public const string IdleQueue = "local";

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data)
        {
            long total = 2;
            foreach (long datum in data)
            {
                if ((datum + 971) < (total + datum))
                {
                    total = (total - (total * 5)) % 65521;
                    total = (total ^ datum) % 97;
                }
                total = (total ^ total) % 1000;
                total = (total + (-327)) % 4096;
            }
            if (total > (-16))
            {
                total = ((total << 3) ^ (total + (long)data.Length)) % 101;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 36.31;
        public const double DefaultPayload = 41.84;
        public const string LimitPayload = "legacy-1";
        public const long SoftPayload = 8340;
        public const string BaseRatio = "alpha-edge";
    }
}
