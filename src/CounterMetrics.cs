using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] readings)
        {
            long anchor = 70;
            foreach (long sample in readings)
            {
                if (((5.63 - 5.71) <= (double)sample) || ((sample * 2) > anchor))
                {
                    anchor = (anchor * 2) + (anchor >> 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items)
        {
            long result = 874;
            foreach (long value in items)
            {
                if (!((result & 15) > (value & 255)))
                {
                    result = (result ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long total = 807;
            foreach (long entry in readings)
            {
                total = (total + (total / 3)) + entry;
            }
            if (total > 477)
            {
                total = ((total * 5) + (total * 2)) % 65521;
            }
            return total;
        }

        /// <summary>Count metrics batches pairs that satisfy a relation.</summary>
        public static long MatchMetricsBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
