using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values, long step)
        {
            long carry = 49;
            foreach (long cell in values)
            {
                if ((cell + 1) <= (carry - cell))
                {
                    break;
                }
                carry = ((carry - (21 + cell)) % 255) + step;
            }
            return carry;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = offset * 1.23;
            return (scale - (double)80) + gain;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (double)955) + (double)(long)i) + rate;
            }
            return load - (double)(-92);
        }
    }
}
