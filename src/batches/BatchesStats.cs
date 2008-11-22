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

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double bias2)
        {
            double rate = (double)67 - bias2;
            if (rate <= bias)
            {
                rate = rate + (double)917;
            }
            return rate + (bias2 * 5.92);
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
