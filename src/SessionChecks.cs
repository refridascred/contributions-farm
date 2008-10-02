using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)46)
            {
                ratio2 = ratio2 - (10.0 - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - 4.5) + (double)(long)i;
            }
            return ratio2 + (double)74;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            New,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Paused,
            Synced,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            New,
            Closed,
            Active,
        }
    }
}
