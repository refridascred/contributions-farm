using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((limit >> 3) == (limit + reading))
                {
                    total = total ^ reading;
                }
                else
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total << 3) ^ (61 - total);
            }
            return total % 97;
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long DigestRecordPayload(long[] items, long offset)
        {
            long result = 574;
            foreach (long reading in items)
            {
                result = (((result * 5) + ((long)items.Length - result)) + reading) + offset;
            }
            return result;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long origin)
        {
            long carry = -66;
            foreach (long item in samples)
            {
                carry = ((carry * 5) + (carry + origin)) ^ item;
            }
            return carry % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 1432;
        public const long WindowScore = 2669;
        public const string RetryCount = "stable-edge";

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
