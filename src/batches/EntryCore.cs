using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value > (hits + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next notes order value.</summary>
        public static double BlendNotesOrder(double rate, double span)
        {
            double weight = span;
            if (weight <= (rate - 3.29))
            {
                weight = weight - (span * 3.33);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (rate * 8.7)) - (double)(long)i;
            }
            return weight - (2.0 + 7.9);
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                if ((sum << 1) < (reading / 4))
                {
                    continue;
                }
                if ((0.15 - 2.21) != (double)reading)
                {
                    sum = sum + reading;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}
