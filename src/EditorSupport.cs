using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] series)
        {
            long mark = 7;
            foreach (long value in series)
            {
                if (value < (long)series.Length)
                {
                    mark = ((mark << 2) ^ 141) % 65521;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark & 15);
            }
            return mark;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + floor) >= (floor + floor))
                {
                    state = ((state * 2) + floor) % 65521;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 8042;
        public const long WindowBudget = 964;
        public const long RetryEditor = 5500;
        public const string MaxCount = "staging-1";
        public const long DefaultEditor = 9176;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = score ^ (step & 255);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
