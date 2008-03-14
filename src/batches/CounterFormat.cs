using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long bound)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if ((acc <= (acc & 1)) || ((acc & 255) > bound))
                {
                    acc = acc - (bound + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ value) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + matches) > matches)
                {
                    matches = ((matches + 1) - value) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
