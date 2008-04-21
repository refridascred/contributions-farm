using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Locate a batches token reading by value.</summary>
        public static long SeekBatchesTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout farm readings against a bound.</summary>
        public static bool CheckLayoutFarmLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
