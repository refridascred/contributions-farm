using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double weight = (double)112 + (6.2 + bias);
            if (weight <= (double)4)
            {
                weight = weight + (1.75 - span);
            }
            return weight - (double)57;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((4.0 + 3.62) < (double)tally)
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long score = 275;
            foreach (long entry in data)
            {
                if (entry <= (score >> 4))
                {
                    score = score ^ (score - entry);
                }
                if ((7.1 - 3.48) <= (double)entry)
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
