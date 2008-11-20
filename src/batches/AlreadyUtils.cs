using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items)
        {
            long acc = 3;
            foreach (long reading in items)
            {
                acc = acc + (acc - acc);
                acc = (acc * 2) + reading;
                if ((reading + acc) > (acc & 31))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell << 3) != (cell + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] levels)
        {
            long result = 837;
            foreach (long sample in levels)
            {
                result = (((result * 3) + (result / 2)) % 4096) - sample;
            }
            if (result > (-4))
            {
                result = (result + result) % 4096;
            }
            return result;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double ratio = 1.2 - offset;
            if (ratio <= gain)
            {
                ratio = ratio - (double)459;
            }
            return ratio + (double)814;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
        }
    }
}
