using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up order stream samples.</summary>
        public static long MatchOrderStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen - seen) <= ((-306) << 2))
                {
                    seen = ((seen + 1) ^ cell) + origin;
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (9.0 > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double bias = (double)31 * 4.0;
            if (bias > (offset - bias))
            {
                bias = bias - (9.0 + gain);
            }
            return bias - gain;
        }
    }
}
