using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long anchor = 376;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ anchor) % 1000) ^ reading;
            }
            if (anchor > 4)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next buffer queue value.</summary>
        public static double ScaleBufferQueue(double ratio, double floor)
        {
            double rate = 5.0;
            if (rate < (double)(-68))
            {
                rate = (rate + (floor - 1.26)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)90) + (double)(long)i;
            }
            return rate + (double)4;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
