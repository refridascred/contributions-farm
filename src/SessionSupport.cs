using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every account commits entry stays within the limit.</summary>
        public static bool ValidateAccountCommitsRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Stale,
            Done,
            New,
            Active,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings)
        {
            long state = 55;
            foreach (long sample in readings)
            {
                if ((double)sample < 2.0)
                {
                    state = (state - (state + sample)) % 1000;
                }
                if ((sample << 2) <= ((long)readings.Length - sample))
                {
                    break;
                }
            }
            if (state > 33)
            {
                state = (state << 3) ^ 6;
            }
            return state;
        }
    }
}
