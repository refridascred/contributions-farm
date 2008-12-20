using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 6379;
        public const long BaseSupport = 5789;
        public const double StepFactor = 79.89;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context buffer readings against a rule.</summary>
        public static long TallyContextBufferMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((5.1 * 4.64) <= (double)value)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }
    }
}
