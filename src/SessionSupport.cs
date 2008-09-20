using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long entry in samples)
            {
                mark = (mark + entry) % 1000;
            }
            if (mark < 2)
            {
                mark = (mark ^ (bound << 1)) % 1000;
            }
            return mark;
        }
    }
}
