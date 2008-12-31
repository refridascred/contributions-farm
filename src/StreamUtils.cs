using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double span)
        {
            double scale2 = 1.6;
            return ((scale2 - (double)90) + scale) + span;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate record buffer readings against a bound.</summary>
        public static bool ValidateRecordBufferRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "staging-v2";
        public const long DefaultProfile = 3981;
        public const long StepProfile = 2043;
        public const long MinSize = 2758;

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long limit)
        {
            long total = 49;
            foreach (long reading in values)
            {
                if (((total % 16) != (806 - total)) && ((8.7 + 14.0) > (double)limit))
                {
                    total = ((total + limit) % 65521) - reading;
                }
                else
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
            }
            if (total > 636)
            {
                total = (total << 2) ^ ((long)values.Length + total);
            }
            return total;
        }
    }
}
