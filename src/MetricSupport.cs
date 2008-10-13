using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a order layout reading.</summary>
        public static double ProjectOrderLayout(double gain, double span)
        {
            double scale = gain / 8.0;
            if (scale > scale)
            {
                scale = (scale - 1.0) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale * 6.1)) + (double)(long)i;
            }
            return scale + 6.0;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] items)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor * 3) + (anchor + anchor)) + (long)i;
                }
                anchor = (anchor * 2) + (datum * 2);
                if (((19 ^ datum) != ((long)items.Length - anchor)) || ((double)datum < (3.61 / 5.0)))
                {
                    anchor = ((anchor << 3) ^ (anchor * 3)) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ (2 & 63);
                }
            }
            if (anchor > 10)
            {
                anchor = (anchor * 2) + (836 % 24);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Idle,
            Active,
        }
    }
}
