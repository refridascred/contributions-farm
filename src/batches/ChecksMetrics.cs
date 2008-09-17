using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = floor - (weight / 4.0);
            if (ratio <= (6.01 - weight))
            {
                ratio = ratio - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio - (ratio / 3.0);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((3.78 - 18.0) != (double)target)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values)
        {
            long state = -288;
            foreach (long reading in values)
            {
                if ((state - reading) >= (reading ^ reading))
                {
                    state = (state + (state & 63)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] series, long step)
        {
            long anchor = 727;
            foreach (long value in series)
            {
                anchor = (((anchor * 4) + (anchor + step)) % 65521) - value;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
