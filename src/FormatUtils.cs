using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] samples)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                if ((35 - cell) < (acc & 1))
                {
                    acc = (acc ^ (cell + cell)) % 1000;
                }
                else
                {
                    acc = (acc - (acc + 895)) % 101;
                }
            }
            if (acc > 655)
            {
                acc = (acc * 3) + acc;
            }
            return acc;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((43 & 31) >= (hits + (long)items.Length)) && ((((long)items.Length & 1) >= (reading - hits)) || (hits > reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < (bias2 + bias))
            {
                bias2 = bias2 - (double)775;
            }
            else
            {
                bias2 = bias2 - 10.0;
            }
            return bias2 + (double)88;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchInterval = 2253;
        public const double IdleSize = 62.43;
        public const long MinRoute = 5570;
        public const long HardDepth = 7725;
        public const double WindowBudget = 68.5;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
