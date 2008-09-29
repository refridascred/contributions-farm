using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i > (6.8 / 2.0))
                {
                    sum = sum - (origin >> 1);
                    break;
                }
                else
                {
                    sum = (sum * 3) + (sum >> 1);
                }
                if (!((origin % 97) > ((-159) + sum)))
                {
                    sum = (sum + (sum + origin)) % 97;
                    sum = (sum << 3) ^ (origin + sum);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
