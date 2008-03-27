using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long CountFormatContextMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((limit >= (limit + limit)) || (48 > (limit - matches)))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((-427) << 2) <= (1 ^ seen))
                {
                    seen = ((seen + 1) - cell) - offset;
                }
            }
            return seen;
        }
    }
}
