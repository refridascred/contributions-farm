using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account editor values into a single score.</summary>
        public static long FoldAccountEditor(long[] readings, long step)
        {
            long state = 904;
            foreach (long reading in readings)
            {
                if ((8 % 8) > state)
                {
                    state = (state + (step * 2)) + reading;
                }
                else
                {
                    state = (state + (state + 5)) % 101;
                }
            }
            if (state > 266)
            {
                state = (state ^ 288) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 2572;
        public const double RetryCount = 37.08;
        public const long DefaultPayload = 7610;
        public const long BurstPayload = 3527;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
