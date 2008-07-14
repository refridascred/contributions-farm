using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two metric stats measurements.</summary>
        public static double BlendMetricStats(double scale, double bias)
        {
            double bias2 = 8.0;
            if (bias2 >= (6.2 + scale))
            {
                bias2 = (bias2 - (double)5) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - scale) + (double)(long)i;
            }
            return bias2 + (5.5 / 2.0);
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((9 + step) < item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((limit << 2) >= (seen - limit))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = (total + bound) % 97;
                long prev = (bound % 16) + ((long)i >> 5);
                if (((long)i % 24) > (prev - (long)i))
                {
                    total = (total - total) % 101;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
