using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate metric token samples.</summary>
        public static long FoldMetricToken(long[] values, long offset)
        {
            long mark = 6;
            foreach (long sample in values)
            {
                if ((offset / 9) != (sample << 2))
                {
                    mark = (mark + (65 ^ offset)) % 97;
                }
                if (!(mark >= (offset + (-21))))
                {
                    mark = (mark ^ (offset - sample)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a already payload sample.</summary>
        public static long LocateAlreadyPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
