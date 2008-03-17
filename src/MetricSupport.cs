using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry > (origin + origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double gain = (double)35 - (6.01 - bias2);
            if (gain <= bias)
            {
                gain = gain + bias;
            }
            return gain + 14.0;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Synced,
            Dropped,
            Draft,
        }
    }
}
