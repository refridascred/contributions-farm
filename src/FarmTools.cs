using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Active,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data, long step)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                anchor = anchor + (step + reading);
                if (!((step + reading) < (reading + (long)data.Length)))
                {
                    break;
                }
            }
            if (anchor > 133)
            {
                anchor = (anchor ^ (step * 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Dropped,
            Draft,
            New,
        }
    }
}
