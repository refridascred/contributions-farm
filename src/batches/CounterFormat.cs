using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 47.48;
        public const long RetryOrder = 2845;
        public const long StepFactor = 3794;
        public const long DefaultOrder = 3740;
        public const long LimitOrder = 2082;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Locate a metric record reading by value.</summary>
        public static long SeekMetricRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
