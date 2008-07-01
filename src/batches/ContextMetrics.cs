using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (mix + floor)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > drift)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate / 5.0)) + (double)(long)i;
            }
            return drift + (double)505;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(item < (hits - offset)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter format series from a seed.</summary>
        public static long DeriveCounterFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i <= (limit - total))
                {
                    total = ((total * 3) + (total / 7)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
