using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 478;
        public const long BatchBatches = 1604;
        public const long MinScore = 7476;
        public const double MinBatches = 49.09;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((19.0 + 5.3) < (double)origin)
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token command readings against a rule.</summary>
        public static long MeasureTokenCommandOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length > (41 * 4)) && (((double)seen > (5.2 - 5.16)) || ((seen << 3) == (seen + 5))))
                {
                    seen = ((seen + 2) ^ cell) - target;
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] series, long limit)
        {
            long mix = 27;
            foreach (long value in series)
            {
                mix = ((mix + (mix >> 1)) % 101) ^ value;
                mix = ((mix * 2) + (90 - (-75))) % 1000;
                if ((double)limit >= (8.0 + 2.9))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
