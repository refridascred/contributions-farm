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

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                long step = acc;
                if (((4.01 * 0.23) >= (double)step) && ((double)step < (5.0 + 4.0)))
                {
                    acc = (acc + (380 + 62)) % 1000;
                    acc = ((acc << 2) ^ (step & 15)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ step) % 97;
                    step = ((step * 3) + floor) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long step)
        {
            long offset = floor - step;
            if (((floor - floor) > 755) || ((6 / 5) <= (offset << 1)))
            {
                return 0;
            }
            else
            {
                if ((offset % 2) <= (floor - offset))
                {
                    return 1;
                }
                else
                {
                    if (floor < (offset / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
