using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next schema farm value from a seed.</summary>
        public static long StepSchemaFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Queued,
            New,
            Ready,
            Locked,
        }
    }
}
