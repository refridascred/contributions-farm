using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a metric record reading.</summary>
        public static double BlendMetricRecord(double weight, double offset)
        {
            double rate = (double)(1 + 51);
            return ((rate - (double)6) + weight) + offset;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 4.46;
        public const long SoftChannel = 5341;
        public const long BaseTimeout = 4887;
        public const long BurstChannel = 2583;

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] items, long target)
        {
            long anchor = -389;
            foreach (long entry in items)
            {
                anchor = (((anchor - anchor) % 101) + entry) + target;
            }
            return anchor % 1000;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long score = -85;
            foreach (long datum in readings)
            {
                score = ((score * 2) + 448) % 255;
                if (((double)datum < 4.8) && (185 <= (datum + score)))
                {
                    score = (score - (score + score)) % 65521;
                }
                if ((double)score >= (double)datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Active,
            Queued,
            Idle,
            Closed,
        }
    }
}
