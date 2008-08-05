using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchTimeout = 690;
        public const double BaseEntry = 6.05;
        public const double BurstEntry = 98.89;
        public const long DefaultEntry = 3583;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long acc = 834;
            foreach (long reading in readings)
            {
                if (3.9 > (double)acc)
                {
                    acc = (acc + (reading ^ 208)) % 97;
                }
                else
                {
                    acc = (acc ^ (reading - reading)) % 4096;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 2) + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
