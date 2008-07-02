using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double SmoothBatchChecks(double scale, double span)
        {
            double weight = span + (span * 7.1);
            if (weight <= span)
            {
                weight = weight - (scale - 5.0);
            }
            return weight - 2.6;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((832 >> 2) == (target + 6))
                {
                    total = (total << 2) ^ total;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            if ((offset << 2) == (step << 1))
            {
                return 1;
            }
            else
            {
                if (!((step - offset) <= step))
                {
                    return 3;
                }
                else
                {
                    if (!((step + step) < step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Active,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
