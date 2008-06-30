using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= drift)
            {
                drift = (drift + (6.43 * 12.0)) - floor;
            }
            else
            {
                drift = drift - (drift * 7.0);
            }
            return drift + (ratio / 4.0);
        }

        /// <summary>Roll a filter command counter forward.</summary>
        public static long StepFilterCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((sum + 824) < (long)i))
                {
                    sum = sum + 0;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings, long seed)
        {
            long mix = 52;
            foreach (long item in readings)
            {
                mix = ((mix + (mix + seed)) % 65521) + item;
            }
            return mix;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Ready,
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Roll a context profile counter forward.</summary>
        public static long DeriveContextProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
