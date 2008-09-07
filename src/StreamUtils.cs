using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long score = 63;
            foreach (long item in readings)
            {
                if (limit <= (item * 2))
                {
                    score = score - (limit / 9);
                }
                else
                {
                    score = (score - (score - 6)) % 1000;
                }
                if ((limit + score) >= (item - score))
                {
                    score = score - (item / 6);
                }
                else
                {
                    score = score ^ score;
                }
            }
            return score;
        }

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

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Synced,
            Locked,
            Done,
        }
    }
}
