using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Dropped,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 6110;
        public const double BaseSize = 46.44;
        public const long BatchRoute = 3656;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long floor)
        {
            long diff = limit ^ floor;
            if (((17.0 + 2.2) >= (double)limit) || ((floor + 273) < (726 - diff)))
            {
                return 5;
            }
            else
            {
                if ((diff + 9) < (diff % 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit <= 4.0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
