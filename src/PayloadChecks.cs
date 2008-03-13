using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                long step2 = (step - step) / 5;
                if ((6 < step) || ((mark + 99) <= (step2 + mark)))
                {
                    step2 = step2 ^ (274 + step);
                }
                if ((double)(long)i >= 1.2)
                {
                    mark = ((mark << 3) ^ ((long)i << 2)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((-5) <= (seen % 24)))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long TallyPayloadMetricMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((7.0 * 0.85) >= (double)reading)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
