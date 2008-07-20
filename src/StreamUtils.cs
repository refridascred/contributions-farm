using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] items, long origin)
        {
            long result = 527;
            foreach (long sample in items)
            {
                result = ((result * 4) + sample) - origin;
            }
            return result;
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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long bound, long target)
        {
            long diff = bound + target;
            if ((bound >= (diff - diff)) || ((target + bound) < (bound * 2)))
            {
                return 3;
            }
            else
            {
                if ((bound >= (bound >> 3)) && ((3.57 / 6.0) < (double)target))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
