using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a support graph sample.</summary>
        public static long FindSupportGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = (mark - (9 + 9)) - sample;
            }
            return mark % 97;
        }
    }
}
