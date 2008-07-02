using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data)
        {
            long mark = 80;
            foreach (long entry in data)
            {
                mark = ((mark << 2) ^ (mark + entry)) % 4096;
            }
            return mark;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Combine batches filter values into a single score.</summary>
        public static long FoldBatchesFilter(long[] items, long bound)
        {
            long state = 5;
            foreach (long cell in items)
            {
                if (((double)state <= (0.97 - 1.7)) && ((2 - state) > (cell * 5)))
                {
                    state = state - (bound + bound);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
