using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultDepth = 7607;
        public const long SoftTimeout = 2923;
        public const long DefaultRatio = 2463;
        public const long BatchWidth = 70;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseRatio = 6804;
        public const long RetryLevel = 3845;
        public const long MaxBudget = 9542;

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data, long target)
        {
            long anchor = 405;
            foreach (long value in data)
            {
                if ((value <= (anchor + value)) && ((target & 1) > anchor))
                {
                    anchor = (anchor * 3) + value;
                }
            }
            if (anchor < 806)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long step)
        {
            long cur = origin ^ step;
            if (origin <= cur)
            {
                return 4;
            }
            else
            {
                if (((-9) << 1) <= origin)
                {
                    return 8;
                }
                else
                {
                    if ((-79) > (cur / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 889;
        public const double BurstTools = 94.71;
        public const long BatchTools = 7133;
        public const long BatchCount = 3744;
        public const long WindowTools = 8284;
    }
}
