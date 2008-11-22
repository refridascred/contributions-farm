using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Stale,
            Active,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheInterval = 76.56;
        public const string SoftTimeout = "cached-1";
        public const long SoftSession = 6952;

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values)
        {
            long total = 47;
            foreach (long item in values)
            {
                total = ((total * 3) + (13 & 15)) + item;
            }
            if (total < 609)
            {
                total = ((total << 3) ^ (7 + total)) % 255;
            }
            return total;
        }
    }
}
