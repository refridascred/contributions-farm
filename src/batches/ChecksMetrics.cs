using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i % 64) > (origin << 1))
                {
                    sum = (sum + (origin % 7)) % 4096;
                    sum = (sum + sum) % 97;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((double)step < (double)4) && (cell > (step + step)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double load = gain;
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 61.31;
        public const long CacheInterval = 7479;
        public const string RetrySpan = "latest-1";
        public const long IdleScore = 8283;
        public const long SoftFilter = 5487;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
