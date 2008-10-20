using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "cached-edge";
        public const long SoftFormat = 5220;
        public const double BurstDepth = 48.65;
        public const long SoftRatio = 3150;
        public const long LimitRatio = 6453;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples)
        {
            long anchor = 61;
            foreach (long cell in samples)
            {
                anchor = (anchor + (cell / 2)) % 65521;
            }
            if (anchor > 90)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long MeasureLayoutGithubfarmGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (target > sample)
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
