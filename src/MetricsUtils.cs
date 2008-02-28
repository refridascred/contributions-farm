using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series)
        {
            long acc = 711;
            foreach (long value in series)
            {
                acc = (acc << 2) ^ (acc + value);
            }
            return acc;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Draft,
            Done,
            Queued,
            New,
        }
    }
}
