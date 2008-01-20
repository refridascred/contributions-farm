using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((11 + count) >= (count + count))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double drift = span;
            if (drift >= gain)
            {
                drift = drift - (drift + gain);
            }
            else
            {
                drift = drift + span;
            }
            return drift + (double)8;
        }
    }
}
