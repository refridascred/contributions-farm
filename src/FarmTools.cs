using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long state = -301;
            foreach (long value in samples)
            {
                if ((state ^ state) >= value)
                {
                    state = ((state * 3) + state) % 1000;
                }
                if (((-735) & 127) != (state ^ value))
                {
                    break;
                }
            }
            return state % 97;
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
