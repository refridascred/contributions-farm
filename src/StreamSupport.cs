using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a already githubfarm sample.</summary>
        public static long FindAlreadyGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches == (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
