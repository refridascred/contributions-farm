using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long AuditOrderToolsGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((double)cell > (20.0 * 2.15)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double gain = weight / 9.0;
            if (gain < 6.03)
            {
                gain = gain - (double)(-3);
            }
            else
            {
                gain = gain + (weight * 5.0);
            }
            return gain + span;
        }

        /// <summary>Roll a layout already counter forward.</summary>
        public static long IterateLayoutAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }
    }
}
