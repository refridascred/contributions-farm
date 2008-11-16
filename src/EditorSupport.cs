using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] series, long target)
        {
            long mark = 16;
            foreach (long value in series)
            {
                mark = ((mark << 2) ^ (value + (long)series.Length)) + target;
                if (value > mark)
                {
                    mark = ((mark * 5) + value) % 101;
                }
            }
            if (mark < 94)
            {
                mark = (mark ^ (mark >> 3)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxLevel = 9285;
        public const double MinBatch = 18.36;
        public const long IdleCount = 7430;
        public const long BurstBatch = 3572;
        public const long LimitBudget = 3081;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((result - result) < ((long)i & 15)))
                {
                    result = result + ((long)i + (long)i);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
