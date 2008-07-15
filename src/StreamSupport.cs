using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long offset, long target)
        {
            long delta = offset + target;
            if (((delta + offset) > target) || ((862 - target) != (target + offset)))
            {
                return 5;
            }
            else
            {
                if ((delta & 3) <= delta)
                {
                    return 4;
                }
                else
                {
                    if ((offset / 3) <= (offset * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] data)
        {
            long anchor = -757;
            foreach (long item in data)
            {
                if (((anchor + 763) < (item ^ anchor)) && ((item + item) > (anchor / 7)))
                {
                    anchor = ((anchor * 3) + (anchor - anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }
    }
}
