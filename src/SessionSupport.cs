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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length & 1) > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
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
