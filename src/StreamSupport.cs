using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long total = 33;
            foreach (long entry in samples)
            {
                total = total ^ entry;
                total = (total - (total / 9)) % 255;
                if ((double)total > 0.51)
                {
                    total = ((total * 5) + (entry + entry)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Measure how many cache stream samples are out of range.</summary>
        public static long TallyCacheStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen > ((-4) + 477))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
