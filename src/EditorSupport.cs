using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Active,
            Pending,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine schema channel values into a single score.</summary>
        public static long ScoreSchemaChannel(long[] values)
        {
            long mark = 1;
            foreach (long item in values)
            {
                if (mark > item)
                {
                    mark = ((mark << 2) ^ 31) % 65521;
                }
            }
            if (mark > 112)
            {
                mark = (mark - mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a checks profile reading.</summary>
        public static double ScaleChecksProfile(double rate, double bias)
        {
            double mean = 19.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (bias + 3.1)) + (double)(long)i) + rate;
            }
            return mean - bias;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
