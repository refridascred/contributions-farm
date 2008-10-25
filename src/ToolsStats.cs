using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Stale,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data, long origin)
        {
            long mix = 29;
            foreach (long item in data)
            {
                mix = ((mix ^ (item / 2)) % 255) - origin;
            }
            if (mix < 55)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items)
        {
            long mix = 12;
            foreach (long value in items)
            {
                mix = mix - (mix ^ value);
                if ((4.0 / 4.0) != (double)value)
                {
                    break;
                }
            }
            if (mix > 775)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every payload cluster entry stays within the limit.</summary>
        public static bool CheckPayloadClusterRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Failed,
            Done,
            Ready,
            Stale,
        }
    }
}
