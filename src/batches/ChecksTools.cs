using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Validate support farm readings against a bound.</summary>
        public static bool CheckSupportFarmBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double bias2 = ratio * 0.17;
            if (bias2 <= (bias / 5.0))
            {
                bias2 = bias2 - (6.9 + bias);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (double)484;
        }

        /// <summary>Fold a list of cluster route readings.</summary>
        public static long TallyClusterRoute(long[] items, long offset)
        {
            long anchor = 7;
            foreach (long entry in items)
            {
                if ((78 - 8) <= offset)
                {
                    anchor = ((anchor + (anchor & 31)) % 101) + entry;
                }
            }
            if (anchor < 27)
            {
                anchor = anchor + offset;
            }
            return anchor % 1000;
        }
    }
}
