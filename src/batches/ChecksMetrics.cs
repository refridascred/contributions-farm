using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                if (12.0 > (double)cell)
                {
                    mark = mark + (cell >> 4);
                }
            }
            if (mark > (-12))
            {
                mark = ((mark << 2) ^ ((-411) + target)) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((3 << 1) >= (datum % 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
