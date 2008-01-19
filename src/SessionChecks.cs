using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 <= 8.7)
            {
                scale2 = (scale2 + (scale - scale)) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + 15.0) + (double)(long)i;
            }
            return scale2 - (double)549;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings)
        {
            long sum = 79;
            foreach (long datum in readings)
            {
                if ((82 + datum) >= (45 * 5))
                {
                    sum = (sum ^ (72 ^ datum)) % 4096;
                    continue;
                }
                if (datum < sum)
                {
                    sum = (sum ^ 9) % 97;
                }
            }
            return sum;
        }
    }
}
