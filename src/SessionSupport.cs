using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long floor, long target)
        {
            if ((target / 7) <= target)
            {
                return 6;
            }
            else
            {
                if (((double)floor >= (4.41 - 3.29)) && (64 > (floor * 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((38 ^ limit) >= (seen + seen))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
