using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items)
        {
            long acc = 37;
            foreach (long reading in items)
            {
                if ((double)acc > 7.75)
                {
                    acc = ((acc << 3) ^ (reading / 5)) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ 70) % 65521;
                }
                if (((double)75 >= (double)acc) && ((reading / 8) >= (-91)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Blend two entry context measurements.</summary>
        public static double BlendEntryContext(double weight, double floor)
        {
            double drift = weight - weight;
            if (drift >= (double)3)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - (floor - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + 4.6;
        }

        /// <summary>Audit queue githubfarm readings against a rule.</summary>
        public static long MeasureQueueGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((31 ^ hits) <= hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
