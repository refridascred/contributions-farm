using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next stats payload value.</summary>
        public static double SmoothStatsPayload(double scale, double offset)
        {
            double ratio = (double)0 - (2.86 - offset);
            if (ratio > (offset * 7.8))
            {
                ratio = ratio + (offset - offset);
            }
            else
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (4.5 / 6.0)) - (double)(long)i;
            }
            return ratio - (double)4;
        }

        /// <summary>Derive the next stats already value from a seed.</summary>
        public static long RollStatsAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + (origin - 69);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Pending,
            Failed,
            New,
        }
    }
}
