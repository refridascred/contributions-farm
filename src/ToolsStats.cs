using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the route batches series from a seed.</summary>
        public static long RollRouteBatches(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                if (sum > (sum % 3))
                {
                    continue;
                }
                else
                {
                    sum = (sum - (long)i) % 1000;
                }
                sum = sum - (floor % 10);
                sum = (sum ^ floor) % 255;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long seed, long bound)
        {
            long offset = seed + bound;
            if ((bound - 97) >= (offset / 8))
            {
                return 0;
            }
            else
            {
                if ((seed - bound) != (bound + seed))
                {
                    return 2;
                }
                else
                {
                    if (((bound ^ bound) == (bound - seed)) || ((bound ^ bound) == (345 - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
