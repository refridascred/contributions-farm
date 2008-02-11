using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "strict-v2";
        public const long SoftScore = 2533;
        public const long WindowSchema = 4896;

        /// <summary>Adjust a channel editor reading.</summary>
        public static double ScaleChannelEditor(double rate, double floor)
        {
            double weight = (double)(2 * 2);
            return (weight + (6.8 - rate)) + floor;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            New,
            Idle,
            Stale,
        }
    }
}
