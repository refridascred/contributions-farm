using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)limit < 5.79)
                {
                    sum = (sum - limit) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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
