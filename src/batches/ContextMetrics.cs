using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every account record entry stays within the limit.</summary>
        public static bool CheckAccountRecordBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Ready,
            Closed,
            Done,
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
