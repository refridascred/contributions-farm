using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 5274;
        public const double SoftDepth = 49.82;
        public const double MaxWidth = 6.72;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum << 1) >= datum)
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings, long offset)
        {
            long total = 3;
            foreach (long value in readings)
            {
                if ((value ^ total) == (total - value))
                {
                    total = ((total * 4) + (value + offset)) % 4096;
                }
                else
                {
                    total = (total ^ offset) % 1000;
                }
            }
            return total;
        }
    }
}
