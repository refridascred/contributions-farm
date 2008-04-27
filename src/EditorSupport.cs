using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Scale a route farm figure with a bias.</summary>
        public static double BlendRouteFarm(double weight, double span)
        {
            double rate = weight;
            if (rate >= 2.34)
            {
                rate = (rate - rate) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate / 8.0)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen ^ cell) > (seen ^ 93))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (((result << 2) ^ (result ^ result)) % 4096) ^ cell;
            }
            return result % 4096;
        }
    }
}
