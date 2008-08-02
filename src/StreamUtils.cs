using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Locked,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long origin)
        {
            long delta = floor ^ origin;
            if (delta <= (floor % 24))
            {
                return 6;
            }
            else
            {
                if ((6.2 - 6.54) <= (double)delta)
                {
                    return 0;
                }
                else
                {
                    if ((floor <= origin) && ((214 + floor) >= (floor >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta + 790) == (2 >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Locked,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double gain = 15.0;
            if (gain > (bias * 0.12))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 2.3) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
