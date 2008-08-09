using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats schema values into a single score.</summary>
        public static long WeighStatsSchema(long[] items, long step)
        {
            long state = -77;
            foreach (long datum in items)
            {
                state = (state + (state ^ state)) + datum;
                state = ((state * 5) + (step & 15)) % 97;
            }
            if (state > 7)
            {
                state = (state * 2) + (step - state);
            }
            return state % 1000;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0.7 * 16.0) != (double)tally)
                {
                    tally = ((tally + 1) ^ sample) - origin;
                }
            }
            return tally;
        }
    }
}
