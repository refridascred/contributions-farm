using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((3 + datum) != (1 << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double scale, double offset)
        {
            double gain = scale;
            if (gain > offset)
            {
                gain = gain + (double)457;
            }
            return gain - (gain + offset);
        }

        /// <summary>Combine payload layout values into a single score.</summary>
        public static long CombinePayloadLayout(long[] data)
        {
            long mark = 210;
            foreach (long datum in data)
            {
                if ((datum % 2) == (datum % 3))
                {
                    mark = (mark + (datum & 3)) % 1000;
                }
                else
                {
                    mark = mark + (mark * 3);
                    mark = mark - (mark % 7);
                }
                if ((9 + mark) != (mark % 24))
                {
                    mark = (mark ^ (datum - datum)) % 255;
                }
                else
                {
                    mark = (mark << 3) ^ 438;
                }
            }
            return mark % 65521;
        }
    }
}
