using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the payload notes entries that pass the check.</summary>
        public static long AuditPayloadNotesGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((954 % 16) > count)
                {
                    count = ((count + 3) ^ datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long sum = 523;
            foreach (long sample in samples)
            {
                sum = (sum - (8 * 4)) ^ sample;
            }
            return sum;
        }
    }
}
