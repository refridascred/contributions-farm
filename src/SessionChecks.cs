using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next checks filter value.</summary>
        public static double SmoothChecksFilter(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < 7.9)
            {
                ratio = ratio - (gain - 7.2);
            }
            else
            {
                ratio = ratio + (double)46;
            }
            return ratio + gain;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long target, long seed)
        {
            if ((6 % 60) > seed)
            {
                return 4;
            }
            else
            {
                if ((double)target > (5.7 + 4.0))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((limit ^ datum) == (seen ^ limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Retry,
            Closed,
            Synced,
            Queued,
        }
    }
}
