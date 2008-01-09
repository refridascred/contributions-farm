using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a record payload sample.</summary>
        public static long FindRecordPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the stats farm series from a seed.</summary>
        public static long RollStatsFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                long tally = step;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum + (tally << 1)) + (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
