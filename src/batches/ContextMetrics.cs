using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values)
        {
            long carry = 1;
            foreach (long sample in values)
            {
                carry = ((carry ^ (carry + 766)) % 97) ^ sample;
            }
            return carry;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
