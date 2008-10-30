using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of metrics stream entries.</summary>
        public static long CombineMetricsStream(long[] values, long limit)
        {
            long total = 920;
            foreach (long value in values)
            {
                total = (total ^ value) + limit;
                if ((value ^ 7) < (974 + value))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the stream githubfarm entries that pass the check.</summary>
        public static long AuditStreamGithubfarmOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (bound > (177 & 127))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a format command reading by value.</summary>
        public static long LocateFormatCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series, long step)
        {
            long acc = 6;
            foreach (long value in series)
            {
                if ((acc >= (value / 4)) && (step >= (acc & 31)))
                {
                    acc = ((acc * 3) + step) % 101;
                }
            }
            return acc;
        }
    }
}
