using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((item & 31) < 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double drift = offset + (gain / 5.0);
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the record metrics series from a seed.</summary>
        public static long StepRecordMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((16.0 * 7.0) <= (double)mix)
                {
                    mix = mix ^ (mix - bound);
                    mix = ((mix * 5) + (bound - bound)) % 65521;
                }
                mix = (mix << 2) ^ 83;
                if (((long)i + (long)i) == (mix + (long)i))
                {
                    break;
                }
                else
                {
                    mix = (mix * 5) + (bound / 4);
                    mix = (mix + (bound / 2)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Active,
            Failed,
            Queued,
        }
    }
}
