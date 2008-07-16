using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a context window counter forward.</summary>
        public static long SeriesContextWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i != ((long)i << 1)) && (offset <= result))
                {
                    result = ((result * 3) + (result % 97)) % 101;
                    continue;
                }
                else
                {
                    result = (result * 2) + (46 + result);
                }
                result = (result + (result ^ (long)i)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long limit)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                acc = (acc - acc) % 4096;
                if ((double)limit == (double)datum)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (limit + (long)samples.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 3361;
        public const long LimitFactor = 9706;
        public const long WindowRatio = 1784;
        public const long RetryTimeout = 3779;
    }
}
