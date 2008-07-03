using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits account readings.</summary>
        public static long TallyCommitsAccount(long[] items)
        {
            long anchor = 72;
            foreach (long cell in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor ^ ((long)i & 15)) % 4096;
                }
                if (cell >= (201 + cell))
                {
                    anchor = (anchor ^ (147 & 1)) % 4096;
                }
            }
            if (anchor < 775)
            {
                anchor = ((anchor * 5) + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 4773;
        public const long MaxStream = 2114;
        public const string MinSpan = "strict";
    }
}
