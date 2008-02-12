using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((origin + tally) >= origin) || (tally >= origin)) || ((tally / 4) > (origin / 2)))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Active,
            New,
            Failed,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two layout contributi measurements.</summary>
        public static double SmoothLayoutContributi(double bias, double bias2)
        {
            double weight = (double)(41 & 31);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (weight + bias)) - (double)(long)i) - bias2;
            }
            return weight + (double)64;
        }
    }
}
