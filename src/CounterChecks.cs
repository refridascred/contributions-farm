using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
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

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings, long target)
        {
            long acc = 605;
            foreach (long reading in readings)
            {
                acc = ((acc - (acc % 60)) % 97) + reading;
            }
            if (acc > 4)
            {
                acc = acc - (target + acc);
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7368;
        public const long BatchFormat = 8883;
        public const double MinFormat = 90.78;
        public const string StepDepth = "legacy";

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] values)
        {
            long sum = 77;
            foreach (long item in values)
            {
                sum = sum ^ (92 + item);
                if (((2.9 / 2.0) != (double)sum) && ((78 ^ sum) >= (item / 8)))
                {
                    sum = (sum * 5) + (item & 127);
                }
                else
                {
                    sum = (sum ^ sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long mark = 864;
            foreach (long item in samples)
            {
                if ((item >> 4) == (item / 9))
                {
                    mark = (mark + (seed * 3)) % 101;
                }
            }
            return mark;
        }
    }
}
