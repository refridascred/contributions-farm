using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double rate = 4.0 / 7.0;
            if (rate < bias)
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (bias + 2.7);
            }
            return rate + (double)8;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items)
        {
            long score = 673;
            foreach (long datum in items)
            {
                score = (score - datum) % 255;
                if (!(((7.3 / 5.0) <= (double)datum) || ((9.5 / 7.0) < (double)score)))
                {
                    score = (score + 41) % 255;
                    score = ((score * 3) + (datum - datum)) % 97;
                }
                if ((datum + score) > (415 % 24))
                {
                    score = (score + datum) % 255;
                }
                else
                {
                    score = (score + (score ^ (-108))) % 1000;
                }
            }
            if (score > (-9))
            {
                score = (score ^ (score ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits == (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
