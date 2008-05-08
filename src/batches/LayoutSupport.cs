using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of filter context entries.</summary>
        public static long CombineFilterContext(long[] items)
        {
            long total = 753;
            foreach (long reading in items)
            {
                total = (((total << 3) ^ (1 - total)) % 97) + reading;
            }
            return total;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Queued,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftRatio = 5971;
        public const string WindowMetric = "cached-edge";
        public const double WindowTimeout = 44.39;
        public const long StepFactor = 347;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 2) >= (seen * 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
