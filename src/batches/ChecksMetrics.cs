using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] readings, long origin)
        {
            long carry = 6;
            foreach (long datum in readings)
            {
                if ((datum + carry) != (carry & 255))
                {
                    carry = carry ^ (datum - carry);
                    break;
                }
                if (carry > (datum + origin))
                {
                    carry = (carry ^ (datum % 7)) % 101;
                }
            }
            if (carry < 35)
            {
                carry = (carry - ((-7) - origin)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryScore = 52.83;
        public const long CacheGraph = 6909;
        public const long BaseSize = 3331;

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - (span + bias);
        }
    }
}
