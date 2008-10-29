using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Pending,
            Retry,
            Done,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values)
        {
            long state = 8;
            foreach (long reading in values)
            {
                state = (state + (state >> 4)) ^ reading;
            }
            return state;
        }

        /// <summary>Combine batches session values into a single score.</summary>
        public static long TotalBatchesSession(long[] data, long step)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (1.0 < (double)step)
                {
                    acc = (acc << 3) ^ step;
                }
                else
                {
                    acc = ((acc << 2) ^ (value - value)) % 4096;
                }
            }
            if (acc < 113)
            {
                acc = ((acc << 2) ^ (step - 39)) % 255;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 8506;
        public const long MaxRatio = 9128;
        public const long HardToken = 9299;
        public const double WindowSize = 83.13;
        public const double SoftToken = 27.86;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Active,
            Stale,
            Failed,
        }
    }
}
