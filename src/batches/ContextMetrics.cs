using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter profile entries.</summary>
        public static long TallyFilterProfile(long[] levels, long limit)
        {
            long anchor = 186;
            foreach (long item in levels)
            {
                anchor = anchor ^ anchor;
                if ((limit <= (limit & 15)) && ((limit - limit) != (item << 3)))
                {
                    anchor = (anchor + (long)levels.Length) % 255;
                    continue;
                }
                if ((item + limit) != (97 % 24))
                {
                    anchor = ((anchor * 4) + (limit + 820)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFactor = 9964;
        public const long SoftFilter = 6369;
        public const long HardSize = 7959;
        public const long MinSpan = 7820;
        public const double WindowLevel = 14.78;
    }
}
