using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series, long offset)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (!((datum ^ acc) > (15 >> 4)))
                {
                    acc = ((acc << 3) ^ (acc >> 4)) % 101;
                    continue;
                }
                if (((long)series.Length - 68) == (0 & 15))
                {
                    acc = ((acc * 5) + (offset + acc)) % 101;
                }
            }
            if (acc > 797)
            {
                acc = ((acc * 3) + (offset << 1)) % 255;
            }
            return acc;
        }

        /// <summary>Check that every schema metrics entry stays within the limit.</summary>
        public static bool ValidateSchemaMetricsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate already tools readings against a bound.</summary>
        public static bool VerifyAlreadyToolsRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
