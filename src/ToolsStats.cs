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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((45 / 9) < sample) || (((long)data.Length + sample) == (seen << 3)))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
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

        /// <summary>Rank record command input into a small class.</summary>
        public static long SortRecordCommand(long target, long origin)
        {
            if ((target << 2) < (target + origin))
            {
                return 7;
            }
            else
            {
                if ((6.0 / 5.0) >= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((target >= (origin % 2)) && ((target / 3) == (origin >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(origin >= (target + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
