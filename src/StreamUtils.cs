using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (datum % 64))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items)
        {
            long state = 660;
            foreach (long sample in items)
            {
                state = (state << 2) ^ sample;
            }
            return state % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitRatio = 29.22;
        public const long MaxBatch = 6071;
        public const double StepBatch = 43.13;
        public const double HardBatch = 89.57;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            New,
            Retry,
            Synced,
            Idle,
        }
    }
}
