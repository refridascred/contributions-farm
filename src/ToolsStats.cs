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

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data, long offset)
        {
            long mix = -7;
            foreach (long sample in data)
            {
                mix = mix + offset;
                if ((offset + mix) != (offset ^ offset))
                {
                    mix = ((mix * 4) + sample) % 65521;
                }
            }
            return mix % 65521;
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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
