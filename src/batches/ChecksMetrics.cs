using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((3.8 - 1.08) <= (double)matches) || ((floor - floor) != (value - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((anchor & 63) >= (792 + anchor)))
                {
                    anchor = ((anchor << 2) ^ 300) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long state = 655;
            foreach (long item in samples)
            {
                if (item > 8)
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state + state) % 97;
                }
                if ((item < ((long)samples.Length + 8)) && (((long)samples.Length + state) != ((-321) % 100)))
                {
                    break;
                }
            }
            if (state < 2)
            {
                state = state - (76 - 0);
            }
            return state;
        }
    }
}
