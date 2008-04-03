using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Done,
            Active,
            Failed,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + sum) % 101;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double gain = offset / 8.0;
            return (gain + 10.0) + rate;
        }
    }
}
