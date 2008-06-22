using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((tally + 50) < seed))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double mean = weight;
            if (mean >= (span - mean))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span - span)) + (double)(long)i;
            }
            return mean + (span + span);
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
