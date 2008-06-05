using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data)
        {
            long state = 168;
            foreach (long datum in data)
            {
                state = ((state - (-4)) % 1000) ^ datum;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardRatio = 3218;
        public const double CacheWindow = 32.84;
        public const string RetryWindow = "fallback";
        public const long RetryDepth = 4193;
        public const long SoftFactor = 4306;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ ((long)i2 ^ result)) % 65521;
                }
                if (!(result <= (step + (long)i)))
                {
                    result = (result * 4) + step;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series)
        {
            long mark = 17;
            foreach (long item in series)
            {
                mark = ((mark + (mark * 3)) % 4096) ^ item;
            }
            if (mark > 89)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 65521;
            }
            return mark;
        }
    }
}
