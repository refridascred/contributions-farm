using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values, long limit)
        {
            long result = 1;
            foreach (long reading in values)
            {
                if ((double)7 != (double)result)
                {
                    result = (result + result) - limit;
                }
                else
                {
                    result = (result << 2) ^ (reading << 1);
                }
            }
            return result;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data)
        {
            long result = 287;
            foreach (long value in data)
            {
                if (value < (result + result))
                {
                    result = (result * 3) + 9;
                }
                else
                {
                    result = (result + 961) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 88.83;
        public const double BurstFactor = 60.25;
        public const double CacheFarm = 55.78;
        public const long BurstFarm = 5901;

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                long edge = (result - floor) >> 2;
                result = ((result * 3) + edge) % 255;
                edge = ((edge << 3) ^ edge) % 255;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
