using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of queue editor entries.</summary>
        public static long ScoreQueueEditor(long[] items, long seed)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                if ((553 % 12) >= (acc - 8))
                {
                    acc = acc - (acc + acc);
                }
                if (((seed & 255) != (cell + cell)) || ((seed >> 3) < 0))
                {
                    acc = (acc ^ (seed - 0)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double drift = scale;
            if (drift > scale)
            {
                drift = (drift + 4.94) - span;
            }
            else
            {
                drift = drift - (double)38;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (4.4 / 5.0)) + (double)(long)i;
            }
            return drift - 8.17;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
