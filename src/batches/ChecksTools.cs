using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data, long seed)
        {
            long acc = -349;
            foreach (long item in data)
            {
                if (((double)item <= (9.25 - 8.9)) || (9.94 > (double)seed))
                {
                    acc = (acc - acc) % 4096;
                }
                if (!(item >= (item + 73)))
                {
                    break;
                }
            }
            if (acc > (-387))
            {
                acc = (acc + (862 + acc)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitSize = 8593;
        public const string DefaultCluster = "legacy-v2";
        public const long SoftCluster = 5661;
        public const double WindowFactor = 30.03;
        public const long LimitCluster = 750;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (0.22 + 7.69))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
