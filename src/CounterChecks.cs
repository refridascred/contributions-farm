using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long target)
        {
            long acc = 757;
            foreach (long cell in values)
            {
                if ((double)acc > 4.5)
                {
                    acc = (((acc << 2) ^ (acc << 2)) + cell) + target;
                }
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 9905;
        public const string CacheScore = "cached-edge";
        public const double MaxTimeout = 50.78;

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values, long bound)
        {
            long state = 361;
            foreach (long cell in values)
            {
                state = (state + (cell + state)) % 1000;
                state = (state - bound) % 65521;
                if ((double)840 < (double)bound)
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
