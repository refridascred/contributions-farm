using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 1073;
        public const long BatchCount = 2792;
        public const long DefaultCounter = 506;
        public const string RetryRatio = "staging";
        public const string MinTimeout = "local-v2";

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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((5 & 31) != (5 + sample)))
                {
                    count = count + 1;
                }
            }
            return count;
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
