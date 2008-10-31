using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Idle,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 72;
            foreach (long value in levels)
            {
                if ((value + (long)levels.Length) >= (90 / 5))
                {
                    result = (result - (value - result)) % 65521;
                }
            }
            if (result > 6)
            {
                result = (result << 2) ^ (41 - result);
            }
            return result % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (1 >= (entry & 15))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool GuardFarmPayloadBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
