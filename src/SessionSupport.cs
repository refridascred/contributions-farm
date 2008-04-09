using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + 13) <= (tally + tally))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm order readings against a rule.</summary>
        public static long AuditGithubfarmOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum - tally) == (tally * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double weight = (double)(22 / 9);
            if (weight < scale)
            {
                weight = weight - (double)164;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (bias / 4.0)) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
