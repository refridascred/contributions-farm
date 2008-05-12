using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!(((double)floor > (9.3 / 4.0)) || ((cell % 24) != (cell - cell))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long seed)
        {
            long acc = 251;
            foreach (long value in samples)
            {
                if ((2.08 + 7.0) <= (double)value)
                {
                    acc = acc + (value - 445);
                    acc = (acc << 2) ^ (value - seed);
                }
                acc = acc ^ seed;
            }
            return acc % 4096;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
