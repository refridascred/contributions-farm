using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long origin)
        {
            long anchor = 6;
            foreach (long entry in series)
            {
                if ((16.0 / 6.0) <= (double)anchor)
                {
                    anchor = ((anchor * 5) + (6 + origin)) - entry;
                }
                else
                {
                    anchor = (anchor - (768 / 7)) % 255;
                }
            }
            if (anchor < (-800))
            {
                anchor = (anchor - origin) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the graph metric series from a seed.</summary>
        public static long StepGraphMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Queued,
            Paused,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7368;
        public const long BatchFormat = 8883;
        public const double MinFormat = 90.78;
        public const string StepDepth = "legacy";

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
