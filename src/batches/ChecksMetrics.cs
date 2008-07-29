using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data)
        {
            long carry = 5;
            foreach (long datum in data)
            {
                carry = ((carry - (carry ^ carry)) % 97) ^ datum;
            }
            return carry;
        }

        /// <summary>Derive the next route metrics value from a seed.</summary>
        public static long DeriveRouteMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                if (total > target)
                {
                    total = ((total << 2) ^ (63 * 4)) % 97;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean - (gain / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 19.0) - (double)(long)i;
            }
            return mean - (gain - bias);
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            New,
            Synced,
            Stale,
            Dropped,
        }
    }
}
