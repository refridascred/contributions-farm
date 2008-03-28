using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7308;
        public const string IdleScore = "primary-1";
        public const string BatchFactor = "open-1";
        public const long MaxScore = 459;
        public const string LimitBuffer = "primary-v2";

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double rate, double floor)
        {
            double bias = floor;
            if (bias > (double)84)
            {
                bias = bias - (double)1;
            }
            else
            {
                bias = bias - 4.22;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (floor - rate);
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double ratio = scale * 7.18;
            if (ratio <= floor)
            {
                ratio = ratio - (double)159;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Synced,
            Draft,
        }
    }
}
