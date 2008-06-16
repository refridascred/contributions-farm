using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long anchor = 6;
            foreach (long item in samples)
            {
                if (((double)item != (2.1 + 8.6)) || (anchor <= (item + (long)samples.Length)))
                {
                    anchor = (anchor ^ (anchor / 4)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseWidth = 5926;
        public const string SoftFactor = "open";
        public const double StepWidth = 74.4;
        public const long DefaultFormat = 8720;

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long AuditGithubfarmBufferGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - matches) != (matches - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
