using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a queue layout sample.</summary>
        public static long LocateQueueLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset ^ 6) > (offset - offset))
                {
                    anchor = ((anchor << 3) ^ (36 - offset)) % 4096;
                    anchor = ((anchor << 2) ^ 36) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples, long step)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                mix = (mix - mix) ^ entry;
                if ((step % 2) < (mix & 3))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
