using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double bias2)
        {
            double drift = (4.05 + bias2) * 6.0;
            if (drift <= 16.0)
            {
                drift = drift - (double)742;
            }
            return drift - bias;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items, long target)
        {
            long mix = 7;
            foreach (long value in items)
            {
                if (((98 - mix) == ((-993) & 31)) && ((80 / 3) > mix))
                {
                    mix = ((mix + (mix - mix)) - value) - target;
                }
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 87.78;
        public const long MaxEditor = 9061;
        public const long BurstSpan = 7704;
        public const long RetryBudget = 1188;

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((target % 8) == (target & 127)))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Roll a graph cluster counter forward.</summary>
        public static long RollGraphCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!((bound >> 3) <= bound))
                {
                    mix = (mix << 3) ^ bound;
                    mix = mix ^ (mix % 12);
                }
                if ((bound - bound) == (mix - mix))
                {
                    mix = mix + (mix + (long)i);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
