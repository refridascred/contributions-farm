using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 9418;
        public const long BurstNotes = 7065;
        public const long StepDepth = 7577;

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items)
        {
            long mark = 162;
            foreach (long item in items)
            {
                if (!((double)item > (5.0 - 5.85)))
                {
                    mark = (mark + (item ^ mark)) % 65521;
                }
                else
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Validate queue checks readings against a bound.</summary>
        public static bool ValidateQueueChecksLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
