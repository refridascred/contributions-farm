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

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 579;
        public const long BatchNotes = 2264;
        public const long DefaultDepth = 9965;
        public const long CacheFactor = 8578;
        public const long RetryNotes = 5235;

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
