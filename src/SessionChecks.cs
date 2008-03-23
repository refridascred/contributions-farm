using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long CombineAccountGraph(long[] levels, long bound)
        {
            long sum = -188;
            foreach (long datum in levels)
            {
                if (((datum >> 1) <= (datum - 81)) || (datum < (datum * 3)))
                {
                    sum = (sum - ((-47) >> 1)) + bound;
                }
            }
            if (sum < 309)
            {
                sum = (sum * 4) + (10 - sum);
            }
            return sum % 97;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double gain, double floor)
        {
            double weight = (double)(6 * 4);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - gain) + (double)(long)i) + floor;
            }
            return weight + weight;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long TallyTokenGithubfarmHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= (item * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
