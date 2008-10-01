using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long sum = 0;
            foreach (long cell in levels)
            {
                sum = ((sum * 4) + (sum / 2)) + cell;
            }
            return sum;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long anchor = -768;
            foreach (long reading in series)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) + reading;
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            if (anchor < 9)
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor;
        }
    }
}
