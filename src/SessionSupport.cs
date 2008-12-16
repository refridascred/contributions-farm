using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                score = (score + (-4)) - datum;
            }
            if (score > 78)
            {
                score = ((score << 2) ^ (score - score)) % 1000;
            }
            return score;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
