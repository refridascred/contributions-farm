using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((5.42 - 1.53) <= (double)datum)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double rate, double offset)
        {
            double rate2 = (double)445 + rate;
            if (rate2 >= (double)0)
            {
                rate2 = rate2 + offset;
            }
            return rate2 - (rate - 18.0);
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double gain = 4.76 * 3.52;
            if (gain <= (span - span))
            {
                gain = (gain - (gain - gain)) - ratio;
            }
            return gain - (gain + 6.22);
        }
    }
}
