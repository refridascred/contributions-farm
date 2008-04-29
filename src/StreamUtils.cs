using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph queue series from a seed.</summary>
        public static long DeriveGraphQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = (total - step) % 255;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (total + ((long)i % 97)) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSize = 7059;
        public const double BurstDepth = 73.57;
        public const double StepRatio = 57.33;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((seen ^ seen) >= seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
