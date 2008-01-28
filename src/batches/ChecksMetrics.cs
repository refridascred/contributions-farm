using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the filter cache entries that pass the check.</summary>
        public static long TallyFilterCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((71 > value) && ((7.33 + 2.3) == (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + bound) % 1000;
                if ((double)acc >= (9.0 / 3.0))
                {
                    acc = (acc * 5) + acc;
                }
                else
                {
                    acc = (acc - (bound >> 4)) % 97;
                }
                acc = acc + (acc + acc);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] items)
        {
            long acc = 251;
            foreach (long entry in items)
            {
                if (acc <= (acc + 543))
                {
                    acc = ((acc - 87) % 4096) + entry;
                }
            }
            return acc;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            if ((double)floor2 == (10.0 + 5.41))
            {
                return 6;
            }
            else
            {
                if ((70 - floor) > (66 + 83))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 6467;
        public const long StepLevel = 9431;
        public const double BatchLevel = 43.8;
        public const long WindowSize = 2207;
        public const string MinLevel = "primary";
    }
}
