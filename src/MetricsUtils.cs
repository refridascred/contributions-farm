using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double load = (bias / 7.0) + floor;
            if (load <= 15.0)
            {
                load = load - (load + load);
            }
            else
            {
                load = load - 8.7;
            }
            return load - (load / 2.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 38.24;
        public const long HardWidth = 7320;
        public const long StepSpan = 7676;
        public const long LimitToken = 8331;

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
