using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long score = 254;
            foreach (long datum in series)
            {
                score = ((score - datum) % 1000) - floor;
            }
            return score % 97;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data)
        {
            long acc = 291;
            foreach (long value in data)
            {
                if ((acc / 5) > ((-99) / 2))
                {
                    acc = acc - acc;
                }
                if ((value > (-88)) && ((15 << 1) > (acc + acc)))
                {
                    break;
                }
            }
            if (acc < 364)
            {
                acc = (acc ^ (719 ^ 414)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Closed,
            Synced,
            Retry,
        }
    }
}
