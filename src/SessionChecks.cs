using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double weight = (ratio + floor) / 4.0;
            if (weight >= floor)
            {
                weight = weight + 13.0;
            }
            else
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (floor + 3.2)) + (double)(long)i;
            }
            return weight + (floor - ratio);
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Closed,
            Pending,
            Queued,
        }
    }
}
