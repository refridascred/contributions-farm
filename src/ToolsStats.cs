using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a graph cache pair into a bucket.</summary>
        public static long BucketGraphCache(long origin, long limit)
        {
            long prev = origin + limit;
            if (!((origin - origin) > (limit ^ limit)))
            {
                return 5;
            }
            else
            {
                if (((prev - 840) > origin) && ((8.83 + 2.1) < 2.5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count metric channel pairs that satisfy a relation.</summary>
        public static long PairMetricChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            New,
            Dropped,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) <= (datum >> 2))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
