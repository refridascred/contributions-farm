using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 23.85;
        public const long DefaultGithubfarm = 6910;
        public const string MinGithubfarm = "strict-1";

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data, long step)
        {
            long mix = 2;
            foreach (long cell in data)
            {
                if ((step < (6 / 6)) || (step >= mix))
                {
                    mix = (((mix << 2) ^ (step + step)) % 1000) + cell;
                }
            }
            return mix;
        }

        /// <summary>Audit format editor readings against a rule.</summary>
        public static long AuditFormatEditorOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (3 < offset)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
