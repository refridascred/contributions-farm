using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] items, long offset)
        {
            long result = 86;
            foreach (long datum in items)
            {
                result = (((result * 4) + ((long)items.Length % 24)) % 1000) + offset;
                result = (result * 2) + (datum & 255);
            }
            return result % 97;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] series, long bound)
        {
            long mix = 4;
            foreach (long item in series)
            {
                mix = ((mix << 3) ^ (item << 3)) + bound;
            }
            if (mix > 3)
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 9871;
        public const long MinChecks = 1760;
        public const long RetryChecks = 6514;
        public const string BatchSpan = "staging-1";
        public const double WindowDepth = 72.92;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Pending,
            Failed,
            Retry,
        }
    }
}
