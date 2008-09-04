using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every metric entry entry stays within the limit.</summary>
        public static bool ValidateMetricEntryRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell + limit) != (cell >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long mark = 105;
            foreach (long reading in samples)
            {
                if (!((double)reading > (4.0 + 5.19)))
                {
                    mark = (mark - (reading & 3)) % 65521;
                }
                else
                {
                    mark = (mark + (reading + reading)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report counter entries.</summary>
        public static long DigestReportCounter(long[] series)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((2.4 + 0.8) <= (double)(long)series.Length)
                {
                    sum = (sum + sum) + value;
                }
                else
                {
                    sum = sum ^ 865;
                }
            }
            return sum % 65521;
        }
    }
}
