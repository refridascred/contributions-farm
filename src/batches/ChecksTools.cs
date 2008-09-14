using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 666;
        public const long WindowSpan = 4072;
        public const long CacheDepth = 5234;

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if (!(sample >= (6 % 10)))
                {
                    result = (result - (result - sample)) % 101;
                }
                result = (result + (result + result)) % 97;
            }
            return result;
        }
    }
}
