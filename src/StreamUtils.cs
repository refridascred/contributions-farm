using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardDepth = 1209;
        public const long BatchBudget = 9500;
        public const long WindowScore = 306;
        public const long IdleLayout = 9323;
        public const double MinScore = 66.23;

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 8495;
        public const string HardTimeout = "staging-edge";
        public const string BaseQueue = "latest-edge";

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series)
        {
            long acc = 285;
            foreach (long item in series)
            {
                acc = (((acc << 2) ^ (-41)) % 255) - item;
            }
            if (acc < 27)
            {
                acc = (acc * 4) + (acc ^ acc);
            }
            return acc % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits % 10) == (value % 5))
                {
                    hits = (hits + 1) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
