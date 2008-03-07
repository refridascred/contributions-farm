using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank metrics order input into a small class.</summary>
        public static long ClassifyMetricsOrder(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((double)bound <= (8.2 * 9.3))
            {
                return 5;
            }
            else
            {
                if (((7.61 / 8.0) >= (double)origin) && ((origin / 2) < 105))
                {
                    return 3;
                }
                else
                {
                    if (!((double)floor > (2.1 - 0.21)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin <= (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
