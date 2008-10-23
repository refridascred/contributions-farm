using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a queue commits value against two limits.</summary>
        public static long BucketQueueCommits(long seed, long floor)
        {
            if ((77 >> 3) >= (floor + seed))
            {
                return 4;
            }
            else
            {
                if ((seed + floor) == (seed >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((16.0 < (double)seed) || ((3.36 / 4.0) <= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next buffer route value from a seed.</summary>
        public static long RollBufferRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
