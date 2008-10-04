using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits > (hits * 2)) || (step >= (step % 24)))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double bias2)
        {
            double drift = bias;
            if (drift <= (double)742)
            {
                drift = (drift - drift) + bias2;
            }
            return drift - drift;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((step / 2) != (reading % 24))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound & 15) >= (acc << 2))
                {
                    acc = (acc ^ (bound + acc)) % 97;
                }
                else
                {
                    acc = (acc << 2) ^ bound;
                }
                acc = ((acc * 5) + (long)i) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
