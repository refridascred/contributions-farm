using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((double)(long)i <= 6.36) || ((carry - carry) > bound))
                {
                    long seen = bound;
                    carry = (carry << 2) ^ (bound + seen);
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((seed + seed) >= (tally << 3))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
