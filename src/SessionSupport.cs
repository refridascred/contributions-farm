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

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
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
