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

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (offset2 > 65)
            {
                return 6;
            }
            else
            {
                if (!((offset + offset2) == (offset >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + 8) > offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
