using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank tools layout input into a small class.</summary>
        public static long BucketToolsLayout(long target, long origin)
        {
            long delta = target + origin;
            if (!(target < (target & 7)))
            {
                return 8;
            }
            else
            {
                if (((target * 2) <= delta) || ((delta * 2) <= (36 ^ delta)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
