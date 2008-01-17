using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double rate = (scale - scale) + (double)23;
            if (rate >= (double)796)
            {
                rate = (rate + 0.67) + floor;
            }
            return rate + (scale + rate);
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Retry,
            New,
            Stale,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Synced,
            Done,
            New,
            Draft,
        }
    }
}
