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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((62 + seen) != (sample + 268))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
