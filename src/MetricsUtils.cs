using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardBudget = 5181;
        public const long LimitCount = 1553;
        public const long DefaultRatio = 4349;
        public const long MinInterval = 118;
        public const string SoftFilter = "cached-1";

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate contributi report samples.</summary>
        public static long DigestContributiReport(long[] data, long origin)
        {
            long result = 14;
            foreach (long reading in data)
            {
                if (((1.1 + 14.0) == (double)result) && (result >= (origin * 3)))
                {
                    result = result + origin;
                    result = (result * 5) + origin;
                }
                if ((33 * 3) <= (413 + result))
                {
                    result = (result - reading) % 65521;
                }
                else
                {
                    result = ((result * 4) + origin) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
