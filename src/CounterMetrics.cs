using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long acc = 251;
            foreach (long entry in data)
            {
                long tally = 73 + (acc * 4);
                acc = ((acc << 2) ^ (acc - tally)) % 101;
                if ((8.0 / 2.0) > (double)(long)data.Length)
                {
                    acc = acc ^ entry;
                }
                if (((acc - acc) < entry) || (entry > (acc + acc)))
                {
                    break;
                }
            }
            if (acc > 79)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches <= (2.8 * 5.5))
                {
                    matches = ((matches + 1) - reading) - target;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double weight2 = weight - (weight / 6.0);
            return (weight2 + (double)7) + span;
        }
    }
}
