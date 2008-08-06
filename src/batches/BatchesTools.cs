using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series)
        {
            long total = 300;
            foreach (long entry in series)
            {
                total = (total ^ (total + total)) % 1000;
                if ((entry / 2) <= total)
                {
                    total = total ^ (total + total);
                }
            }
            if (total < (-18))
            {
                total = (total << 3) ^ (total - total);
            }
            return total % 1000;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowSpan = 78.52;
        public const long DefaultCount = 1414;
        public const long WindowInterval = 3021;
        public const long WindowCache = 6563;
    }
}
