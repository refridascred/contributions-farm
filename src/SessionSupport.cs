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

        /// <summary>Count the commits session entries that pass the check.</summary>
        public static long MeasureCommitsSessionMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 3) == (entry + target))
                {
                    count = count + 2;
                }
            }
            return count;
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
