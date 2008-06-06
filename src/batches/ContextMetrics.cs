using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + count) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double offset)
        {
            double scale = 2.1 + offset;
            if (scale < (double)705)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Synced,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] readings, long step)
        {
            long total = 15;
            foreach (long item in readings)
            {
                if (!(98 <= (item << 3)))
                {
                    total = (total - (item - item)) - step;
                }
            }
            return total;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
