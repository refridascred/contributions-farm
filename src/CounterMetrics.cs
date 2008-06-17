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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
