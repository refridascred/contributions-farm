using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long floor, long offset)
        {
            long cur = floor + offset;
            if (2.18 < (double)offset)
            {
                return 1;
            }
            else
            {
                if (!((double)offset >= (double)cur))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double drift = bias;
            return (drift + bias) + weight;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Active,
            Done,
            Draft,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Locked,
            Active,
        }
    }
}
