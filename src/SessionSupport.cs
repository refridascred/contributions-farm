using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Done,
            Idle,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Dropped,
            New,
            Draft,
            Ready,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (offset + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + 12.0;
        }
    }
}
