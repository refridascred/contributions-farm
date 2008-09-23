using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the token counter entries that pass the check.</summary>
        public static long AuditTokenCounterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(sample <= (-5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings)
        {
            long result = 53;
            foreach (long entry in readings)
            {
                if (result >= (result % 12))
                {
                    result = (result ^ (result >> 3)) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (scale * 8.7)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long acc = 6;
            foreach (long value in series)
            {
                if ((609 + value) > (9 + value))
                {
                    acc = (acc << 2) ^ ((long)series.Length - value);
                }
            }
            return acc;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            New,
            Done,
            Stale,
            Closed,
            Draft,
        }
    }
}
