using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + 35) <= (seed << 1))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((hits <= ((long)levels.Length + 39)) || ((origin << 3) >= 95)))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Roll a githubfarm already counter forward.</summary>
        public static long StepGithubfarmAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
