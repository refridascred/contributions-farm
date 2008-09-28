using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((entry - entry) <= step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics context readings against a rule.</summary>
        public static long CountMetricsContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value << 2) != (9 >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            New,
            Pending,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] data, long offset)
        {
            long mark = 28;
            foreach (long reading in data)
            {
                if ((mark + reading) >= mark)
                {
                    mark = ((mark + 3) % 101) - offset;
                }
            }
            return mark;
        }

        /// <summary>Validate format profile readings against a bound.</summary>
        public static bool ValidateFormatProfileLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
