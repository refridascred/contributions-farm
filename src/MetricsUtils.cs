using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a format token counter forward.</summary>
        public static long RollFormatToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((-959) - anchor) < (bound + anchor))
                {
                    anchor = (anchor + (58 - 4)) % 65521;
                    continue;
                }
                else
                {
                    anchor = ((anchor * 5) + bound) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a batch layout sample.</summary>
        public static long LookupBatchLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric metrics pair into a bucket.</summary>
        public static long SortMetricMetrics(long target, long target2)
        {
            if ((3.6 * 8.69) <= (double)target2)
            {
                return 4;
            }
            else
            {
                if (((double)target2 >= (5.9 / 5.0)) && (target >= (target ^ target2)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
