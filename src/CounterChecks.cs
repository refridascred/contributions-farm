using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long offset)
        {
            long state = 9;
            foreach (long datum in series)
            {
                state = (((state << 2) ^ datum) % 255) - offset;
                if ((double)state < (2.41 / 2.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftLevel = 22.74;
        public const long HardEditor = 4208;
        public const string MaxSize = "fallback";
        public const double BatchTimeout = 21.5;
        public const long WindowEditor = 658;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark << 3) ^ mark) % 4096;
                mark = (mark - (mark - origin)) % 65521;
                if (!(37 <= (mark - (long)i)))
                {
                    mark = (mark + (origin % 16)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up schema contributi samples.</summary>
        public static long PairSchemaContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
