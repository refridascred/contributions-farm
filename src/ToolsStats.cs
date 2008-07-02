using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data)
        {
            long mark = 80;
            foreach (long entry in data)
            {
                mark = ((mark << 2) ^ (mark + entry)) % 4096;
            }
            return mark;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long floor)
        {
            long score = 3;
            foreach (long item in series)
            {
                if ((double)item < 9.43)
                {
                    score = (((score << 3) ^ (item + score)) % 65521) + floor;
                }
            }
            return score;
        }

        /// <summary>Combine batches filter values into a single score.</summary>
        public static long FoldBatchesFilter(long[] items, long bound)
        {
            long state = 5;
            foreach (long cell in items)
            {
                if (((double)state <= (0.97 - 1.7)) && ((2 - state) > (cell * 5)))
                {
                    state = state - (bound + bound);
                }
            }
            return state % 97;
        }

        /// <summary>Count the editor payload entries that pass the check.</summary>
        public static long MeasureEditorPayloadHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((499 & 255) != (limit >> 4)) && (matches >= (8 ^ 512))) || ((2 - 7) >= datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ (target + target)) % 97;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
