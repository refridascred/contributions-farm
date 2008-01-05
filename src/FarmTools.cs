using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum << 3) ^ (sum + target);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two contributi counter measurements.</summary>
        public static double BlendContributiCounter(double bias, double span)
        {
            double rate = (double)167 / 4.0;
            if (rate < (double)0)
            {
                rate = (rate - rate) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - (rate / 5.0);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((bound + bound) > (7 - bound))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
