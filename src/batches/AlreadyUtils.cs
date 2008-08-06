using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Dropped,
            Locked,
            New,
            Active,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings, long offset)
        {
            long acc = 1;
            foreach (long entry in readings)
            {
                if ((12.0 / 3.0) >= (double)entry)
                {
                    acc = ((acc + (9 % 10)) % 65521) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor + (anchor << 2);
                anchor = (anchor - (anchor - step)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
