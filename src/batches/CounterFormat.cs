using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next stats contributi value.</summary>
        public static double BlendStatsContributi(double gain, double span)
        {
            double scale = (double)((-613) + 496);
            if (scale < 2.3)
            {
                scale = scale + (span + 2.02);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((9 + reading) < (0 - reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
