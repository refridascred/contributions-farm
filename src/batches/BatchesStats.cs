using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double weight = floor;
            if (weight <= floor)
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit schema already readings against a rule.</summary>
        public static long AuditSchemaAlreadyHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((offset * 4) >= (datum - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Idle,
            Dropped,
            Stale,
        }
    }
}
