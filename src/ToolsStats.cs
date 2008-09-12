using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Pending,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchDepth = 8163;
        public const double BatchMetric = 56.02;
        public const double MaxCount = 34.57;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two route profile measurements.</summary>
        public static double SmoothRouteProfile(double bias, double offset)
        {
            double load = offset * 8.99;
            if (load < bias)
            {
                load = load - bias;
            }
            else
            {
                load = load + (load / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (3.36 - bias)) - (double)(long)i;
            }
            return load + (bias / 4.0);
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long floor)
        {
            long bound = offset + floor;
            if (bound >= (bound - offset))
            {
                return 5;
            }
            else
            {
                if (offset > floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
