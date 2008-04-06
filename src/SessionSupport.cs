using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((((-18) % 8) == (tally / 4)) || ((5 + bound) < (tally >> 2))))
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double weight, double span)
        {
            double drift = (weight - weight) - weight;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift - (span - span);
        }
    }
}
