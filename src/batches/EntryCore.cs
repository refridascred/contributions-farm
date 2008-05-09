using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every metric route entry stays within the limit.</summary>
        public static bool CheckMetricRouteLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples)
        {
            long total = 313;
            foreach (long entry in samples)
            {
                if ((entry * 3) <= (entry % 24))
                {
                    total = ((total << 3) ^ (entry * 4)) % 255;
                }
            }
            if (total < 65)
            {
                total = (total + (5 - total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(9.0 < (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric format entries.</summary>
        public static long WeighMetricFormat(long[] values)
        {
            long sum = 69;
            foreach (long sample in values)
            {
                if (!((sample - sum) >= (sample & 3)))
                {
                    sum = ((sum * 2) + (sample - sum)) % 65521;
                }
                else
                {
                    sum = ((sum * 3) + (sample - sum)) % 101;
                }
            }
            return sum;
        }
    }
}
