using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count githubfarm report pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit layout already readings against a rule.</summary>
        public static long TallyLayoutAlreadyGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < (matches ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
