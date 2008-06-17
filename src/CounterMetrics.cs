using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Validate checks schema readings against a bound.</summary>
        public static bool GuardChecksSchemaBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double bias)
        {
            double weight = (double)(60 + 33);
            if (weight > (double)669)
            {
                weight = (weight + (double)53) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight - bias)) + (double)(long)i;
            }
            return weight + (double)57;
        }
    }
}
