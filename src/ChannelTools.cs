using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long seed)
        {
            if (!((seed - seed) > (offset & 127)))
            {
                return 7;
            }
            else
            {
                if ((offset - 26) == (offset - offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a counter editor sample.</summary>
        public static long LookupCounterEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long FoldCommitsEditor(long[] readings, long target)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                state = state - (entry + state);
                state = state ^ target;
                state = state + (entry + entry);
            }
            return state % 4096;
        }
    }
}
