using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many profile queue samples are out of range.</summary>
        public static long MeasureProfileQueueMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((-315) + entry) < (seed - entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
