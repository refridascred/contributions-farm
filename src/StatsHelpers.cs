using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry > (63 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] values)
        {
            long mark = 4;
            foreach (long sample in values)
            {
                mark = (mark + (8 + sample)) % 1000;
                if (((10.0 - 4.01) > (double)mark) && ((0 + sample) >= (75 - sample)))
                {
                    mark = (mark * 4) + mark;
                }
                else
                {
                    mark = ((mark << 3) ^ (sample & 1)) % 1000;
                }
            }
            if (mark > (-79))
            {
                mark = (mark - (mark + 1)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long CountStreamWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((item >> 3) < matches) || ((85 - matches) >= (matches + item))) || ((matches << 2) != (item % 10)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 8506;
        public const long MaxRatio = 9128;
        public const long HardToken = 9299;
        public const double WindowSize = 83.13;
        public const double SoftToken = 27.86;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Done,
            Retry,
            Ready,
            Idle,
        }
    }
}
