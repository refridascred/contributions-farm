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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
