using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                bool stale = !(floor > ((long)i - sum));
                if (stale || (((-846) << 2) < (sum + floor)))
                {
                    sum = sum - (sum << 2);
                }
                else
                {
                    sum = (sum << 2) ^ (27 % 12);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum ^ (sum + 60)) - (long)i2;
                    sum = ((sum << 3) ^ (sum >> 5)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine entry layout values into a single score.</summary>
        public static long TotalEntryLayout(long[] readings, long limit)
        {
            long result = 82;
            foreach (long value in readings)
            {
                result = ((((result * 3) + (result - 38)) % 4096) + value) - limit;
            }
            if (result < 96)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
