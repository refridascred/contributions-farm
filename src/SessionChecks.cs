using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count command notes pairs that satisfy a relation.</summary>
        public static long OverlapCommandNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 220;
        public const string CacheSize = "strict-1";
        public const string WindowSpan = "staging-1";
        public const long CacheCounter = 1726;
        public const string RetryCounter = "primary-1";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] samples, long floor)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                if (!((cell % 8) >= (8 * 3)))
                {
                    total = (total ^ 6) % 97;
                }
                if ((floor - total) >= floor)
                {
                    total = total ^ (floor & 255);
                }
                if ((cell & 15) <= total)
                {
                    total = (total - (total << 2)) % 101;
                }
            }
            return total;
        }
    }
}
