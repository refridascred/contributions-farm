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

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = (result - (result << 2)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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

        /// <summary>Match up contributi stream samples.</summary>
        public static long PairContributiStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
