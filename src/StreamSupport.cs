using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values)
        {
            long anchor = 43;
            foreach (long entry in values)
            {
                if (((double)entry > (14.0 / 7.0)) && ((anchor % 7) >= entry))
                {
                    anchor = (anchor ^ (entry << 2)) % 97;
                }
            }
            if (anchor < 74)
            {
                anchor = (anchor * 4) + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (offset > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
