using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((13.0 + 4.4) == (double)tally)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Failed,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((3.2 * 6.3) <= (double)(long)i))
                {
                    mix = (mix << 2) ^ (seed & 63);
                }
                if ((9.79 >= (double)(long)i) && ((mix + (long)i) <= (seed + 48)))
                {
                    mix = ((mix << 3) ^ (seed + mix)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
