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

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long offset)
        {
            long next = floor + offset;
            if (offset < next)
            {
                return 6;
            }
            else
            {
                if ((87 + next) >= (offset >> 4))
                {
                    return 2;
                }
                else
                {
                    if ((16.0 / 7.0) > (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
