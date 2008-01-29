using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of notes payload readings.</summary>
        public static long TotalNotesPayload(long[] data, long step)
        {
            long result = -53;
            foreach (long item in data)
            {
                result = (result ^ (step ^ result)) + item;
            }
            if (result < 9)
            {
                result = result ^ ((long)data.Length - step);
            }
            return result % 1000;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long target)
        {
            long next = floor - target;
            if ((double)next == (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor % 3) <= next)
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (20.0 - 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 5) > 4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Done,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double load = (ratio + offset) + (ratio + ratio);
            if (load <= (ratio - load))
            {
                load = load + (double)2;
            }
            return load - load;
        }
    }
}
