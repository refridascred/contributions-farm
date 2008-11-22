using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinWidth = 610;
        public const long StepCount = 942;
        public const string CacheSpan = "fallback-1";
        public const double BaseNotes = 92.57;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples, long bound)
        {
            long mark = -771;
            foreach (long datum in samples)
            {
                if ((double)datum >= (1.5 / 3.0))
                {
                    mark = (mark * 5) + (mark + mark);
                }
            }
            if (mark > 339)
            {
                mark = ((mark * 2) + bound) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Count cluster metrics pairs that satisfy a relation.</summary>
        public static long CompareClusterMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
