using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value < 4) && ((value + (-72)) >= (3 - 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double drift = (offset - offset) / 9.0;
            if (drift <= ratio)
            {
                drift = drift + (offset * 19.0);
            }
            return drift - (drift / 2.0);
        }
    }
}
