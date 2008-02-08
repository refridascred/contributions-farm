using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series, long step)
        {
            long mix = 364;
            foreach (long datum in series)
            {
                mix = (mix ^ ((long)series.Length << 3)) - step;
                if ((datum + mix) < (mix + mix))
                {
                    mix = (mix << 3) ^ (datum & 31);
                }
                else
                {
                    mix = (mix - (datum ^ mix)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                if ((5.0 - 3.56) != (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (item + anchor)) % 97;
                }
                if (((item - item) < (-6)) || ((double)anchor < (double)57))
                {
                    break;
                }
            }
            if (anchor > (-813))
            {
                anchor = (anchor * 4) + (92 >> 1);
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 3784;
        public const long StepCounter = 5925;
        public const long BaseSize = 5399;
        public const long SoftCounter = 5109;
        public const long RetryCounter = 2945;
    }
}
