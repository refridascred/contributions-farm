using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long delta = offset - target;
            if (!((1.15 * 6.0) > (double)offset))
            {
                return 6;
            }
            else
            {
                if ((offset - target) >= (-34))
                {
                    return 4;
                }
                else
                {
                    if (delta <= (182 ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta - target) < offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "stable-edge";
        public const long SoftLevel = 3312;
        public const long RetryContext = 4596;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Failed,
            Queued,
            Closed,
        }
    }
}
