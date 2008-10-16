using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 3735;
        public const long DefaultScore = 451;
        public const long BaseContext = 1840;
        public const double HardScore = 85.36;

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long mark = 947;
            foreach (long entry in readings)
            {
                if ((mark - entry) == (mark & 7))
                {
                    mark = mark ^ (mark - mark);
                }
            }
            if (mark < 91)
            {
                mark = ((mark << 2) ^ (mark << 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools command series from a seed.</summary>
        public static long StepToolsCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix * 3) + 898) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
