using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Retry,
            Pending,
            Done,
            Active,
        }

        /// <summary>Measure how many cache session samples are out of range.</summary>
        public static long AuditCacheSessionGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample < 3)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double gain, double floor)
        {
            double mean = gain;
            if (mean <= gain)
            {
                mean = (mean - 4.2) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)47) + (double)(long)i;
            }
            return mean + (mean / 5.0);
        }
    }
}
