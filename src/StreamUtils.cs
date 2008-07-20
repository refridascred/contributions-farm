using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double weight, double floor)
        {
            double ratio = weight - (double)(-70);
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (ratio / 4.0)) + (double)(long)i) + floor;
            }
            return ratio - (ratio * 11.0);
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] samples, long floor)
        {
            long acc = 9;
            foreach (long entry in samples)
            {
                acc = acc + (entry ^ acc);
                acc = (acc ^ entry) % 255;
                if ((floor + floor) != (floor - entry))
                {
                    break;
                }
            }
            if (acc < 904)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 6702;
        public const long DefaultSpan = 6030;
        public const long SoftFormat = 4342;

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "local";
        public const long BatchCache = 3911;
        public const double WindowSize = 51.12;
        public const long BurstCache = 5309;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
