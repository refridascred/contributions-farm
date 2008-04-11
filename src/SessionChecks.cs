using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples, long origin)
        {
            long mark = 1;
            foreach (long sample in samples)
            {
                if ((96 - mark) == ((long)samples.Length >> 5))
                {
                    mark = (mark - 207) + origin;
                }
                else
                {
                    mark = (mark << 2) ^ (mark - sample);
                }
            }
            return mark;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long offset, long offset2)
        {
            if ((2.9 + 1.09) < (double)offset2)
            {
                return 0;
            }
            else
            {
                if ((offset > (offset + offset)) && ((offset << 2) <= (offset2 + offset2)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
