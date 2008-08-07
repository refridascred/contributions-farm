using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowTimeout = 34.06;
        public const long DefaultCount = 4634;
        public const long LimitSize = 1234;
        public const long DefaultProfile = 8777;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long mix = 254;
            foreach (long value in items)
            {
                mix = ((mix - (mix - (long)items.Length)) % 97) + value;
            }
            if (mix > 7)
            {
                mix = (mix - mix) % 97;
            }
            return mix % 1000;
        }
    }
}
