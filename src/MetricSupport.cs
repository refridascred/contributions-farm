using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < (tally << 2))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long offset)
        {
            long sum = 21;
            foreach (long datum in readings)
            {
                if ((sum - datum) != (datum - 10))
                {
                    sum = sum ^ (92 << 3);
                }
                else
                {
                    sum = (sum - 147) % 65521;
                }
                if (((long)readings.Length * 4) <= (datum - offset))
                {
                    break;
                }
            }
            if (sum > 596)
            {
                sum = ((sum << 2) ^ (offset + offset)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
