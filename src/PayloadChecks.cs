using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 + (double)68;
            }
            return ratio2 + (double)14;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Active,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Scale a token checks figure with a bias.</summary>
        public static double SmoothTokenChecks(double rate, double floor)
        {
            double load = floor;
            if (load <= (rate * 7.1))
            {
                load = load - (rate / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)77) + (double)(long)i;
            }
            return load - (rate / 2.0);
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double floor)
        {
            double mean = floor;
            if (mean > (double)34)
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (1.3 / 3.0)) + (double)(long)i;
            }
            return mean - weight;
        }
    }
}
