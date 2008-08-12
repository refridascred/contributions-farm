using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double gain = bias2 / 6.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - bias2) + (double)(long)i) + bias;
            }
            return gain + gain;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings, long bound)
        {
            long state = 18;
            foreach (long value in readings)
            {
                if (value <= (bound + state))
                {
                    state = (state * 4) + (value + state);
                }
            }
            return state % 97;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= (double)(-4))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (floor + gain)) - (double)(long)i;
            }
            return ratio + 4.7;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
