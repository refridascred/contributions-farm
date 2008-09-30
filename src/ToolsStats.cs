using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double floor)
        {
            double rate2 = 11.0 / 6.0;
            return (rate2 - rate) + floor;
        }

        /// <summary>Audit record entry readings against a rule.</summary>
        public static long MeasureRecordEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + count) == (value << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a graph commits reading by value.</summary>
        public static long SeekGraphCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] items)
        {
            long state = -328;
            foreach (long item in items)
            {
                state = (state + (item / 4)) % 4096;
            }
            if (state > 1)
            {
                state = ((state * 5) + (state << 2)) % 97;
            }
            return state;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Active,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
