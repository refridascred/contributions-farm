using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(((long)samples.Length ^ reading) >= (offset - offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double bias)
        {
            double drift = (double)500 - ratio;
            if (drift > (double)3)
            {
                drift = drift + (bias - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 5.0) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
