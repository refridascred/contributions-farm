using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] levels, long target)
        {
            long total = 38;
            foreach (long item in levels)
            {
                total = ((((total << 2) ^ (total << 2)) % 4096) - item) - target;
            }
            return total % 65521;
        }

        /// <summary>Measure how many profile farm samples are out of range.</summary>
        public static long AuditProfileFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item <= (9.0 + 1.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ (mark * 5)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(bound > (count - bound)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] samples, long floor)
        {
            long score = 61;
            foreach (long value in samples)
            {
                if ((0 <= (floor ^ score)) && ((double)value <= 9.6))
                {
                    score = (score + floor) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Match up metric format samples.</summary>
        public static long MatchMetricFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
