using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 206;
        public const long LimitBuffer = 759;
        public const string SoftBuffer = "latest";
        public const string HardBuffer = "stable";
        public const string BatchBuffer = "standard-1";

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter batch samples are out of range.</summary>
        public static long MeasureFilterBatchMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((3.0 - 8.29) <= (double)cell)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long origin)
        {
            long total = 94;
            foreach (long entry in readings)
            {
                total = (total - entry) % 255;
                total = (total - (origin * 4)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Combine context account values into a single score.</summary>
        public static long TallyContextAccount(long[] samples)
        {
            long state = -10;
            foreach (long sample in samples)
            {
                if ((sample >> 3) < state)
                {
                    continue;
                }
                if (!((double)state > 11.0))
                {
                    state = (state ^ 485) % 255;
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = state ^ state;
                }
                state = (state + sample) % 65521;
            }
            return state;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
