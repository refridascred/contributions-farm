using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Idle,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] levels, long seed)
        {
            long result = 5;
            foreach (long sample in levels)
            {
                result = (result * 4) + (result & 3);
                if (sample >= (seed ^ seed))
                {
                    continue;
                }
                result = ((result << 2) ^ (seed + sample)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long limit)
        {
            long mix = 37;
            foreach (long item in items)
            {
                mix = (mix ^ (82 ^ limit)) ^ item;
            }
            return mix % 1000;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((double)origin < 8.0)
            {
                return 0;
            }
            else
            {
                if ((next << 1) >= (2 & 255))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
