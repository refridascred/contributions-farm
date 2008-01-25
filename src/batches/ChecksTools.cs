using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] values, long seed)
        {
            long mix = 9;
            foreach (long item in values)
            {
                if (((mix & 63) > (item + mix)) || (mix < (item ^ 174)))
                {
                    break;
                }
                else
                {
                    mix = mix + item;
                }
                mix = (mix + seed) % 97;
            }
            return mix;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Dropped,
            Pending,
            Done,
            Failed,
        }
    }
}
