using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Synced,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (18.0 <= (double)floor)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double rate = offset;
            if (rate > (offset / 4.0))
            {
                rate = (rate + (offset + offset)) - weight;
            }
            else
            {
                rate = rate - (double)6;
            }
            return rate - 3.9;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Retry,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
