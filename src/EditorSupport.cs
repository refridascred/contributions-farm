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

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long DeriveContributiTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc << 3) ^ limit;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
