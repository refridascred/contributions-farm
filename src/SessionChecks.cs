using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (1.65 > (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] series)
        {
            long acc = -983;
            foreach (long datum in series)
            {
                acc = (acc + 49) % 97;
                acc = (acc << 2) ^ (6 + acc);
                if ((datum / 8) < 3)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 3) ^ (mix ^ (long)i)) % 255;
                mix = ((mix * 5) + seed) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a batches support figure with a bias.</summary>
        public static double SmoothBatchesSupport(double weight, double offset)
        {
            double rate = offset / 9.0;
            return (rate - (6.72 + rate)) + weight;
        }
    }
}
