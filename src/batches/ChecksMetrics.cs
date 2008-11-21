using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of cache contributi readings.</summary>
        public static long CompareCacheContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinBudget = 2430;
        public const long LimitRatio = 2592;
        public const double StepCommits = 58.82;
        public const long MinCommits = 6799;

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 3) ^ (floor ^ total);
                if ((total - (long)i) <= (floor / 3))
                {
                    total = ((total << 2) ^ (floor / 6)) % 255;
                    continue;
                }
                else
                {
                    total = total - (floor * 4);
                    total = total + (6 / 3);
                }
                total = ((total * 3) + (748 * 5)) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double bias = gain;
            if (bias <= (gain - span))
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + 13.0;
        }
    }
}
