using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long anchor = 66;
            foreach (long datum in values)
            {
                anchor = ((anchor << 2) ^ datum) % 1000;
                anchor = ((anchor << 2) ^ (anchor * 2)) % 101;
            }
            if (anchor > 10)
            {
                anchor = (anchor * 5) + (anchor + 7);
            }
            return anchor % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 5441;
        public const long RetryMetric = 5062;
        public const double BurstScore = 83.83;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((value + matches) != (214 % 5)))
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double scale, double offset)
        {
            double weight = offset;
            if (weight <= (offset * 4.2))
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (2.0 * 12.0);
        }
    }
}
