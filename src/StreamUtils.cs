using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Pending,
            Active,
        }

        /// <summary>Fold a list of channel buffer readings.</summary>
        public static long TotalChannelBuffer(long[] values, long step)
        {
            long sum = 35;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (cell & 255)) % 101;
                if ((sum + step) <= (cell >> 4))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long limit)
        {
            if ((limit / 4) == (floor - floor))
            {
                return 2;
            }
            else
            {
                if ((floor & 1) != (floor + 86))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double ratio = 12.0;
            if (ratio <= rate)
            {
                ratio = (ratio - (double)(-32)) + bias;
            }
            return ratio + (ratio * 1.0);
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
