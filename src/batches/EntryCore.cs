using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the window format series from a seed.</summary>
        public static long RollWindowFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = total + total;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseRatio = "staging-v2";
        public const long RetryMetrics = 1994;
        public const long MinMetrics = 2457;
        public const long RetrySize = 7524;

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= (floor * 4.77))
            {
                gain2 = (gain2 + (gain2 / 8.0)) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + (double)(-198)) + (double)(long)i;
            }
            return gain2 - (double)9;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Pending,
            Idle,
        }
    }
}
