using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix + (floor + (long)i)) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Retry,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinLevel = 6.52;
        public const double DefaultSupport = 60.66;
        public const long BurstWidth = 8221;
        public const string MaxSize = "latest";

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double gain2 = span;
            return (gain2 - (double)551) + gain;
        }
    }
}
