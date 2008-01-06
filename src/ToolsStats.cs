using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data, long bound)
        {
            long score = 946;
            foreach (long reading in data)
            {
                if ((double)reading > (double)bound)
                {
                    score = score ^ (reading >> 5);
                }
                if (bound < (reading % 60))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 8824;
        public const double RetryCache = 58.63;
        public const long WindowDepth = 693;
        public const long WindowTimeout = 9207;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Paused,
            Queued,
            Failed,
            Draft,
        }
    }
}
