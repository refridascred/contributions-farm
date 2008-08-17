using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long IterateEditorTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 2) ^ 42) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long acc = 7;
            foreach (long sample in values)
            {
                if (sample > (acc & 127))
                {
                    acc = (acc + acc) % 101;
                }
                acc = (acc << 2) ^ (acc / 5);
                if ((acc & 3) <= (acc << 2))
                {
                    acc = (acc * 2) + (4 << 3);
                }
            }
            return acc;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long origin, long origin2)
        {
            long delta = origin + origin2;
            if ((delta * 4) <= origin2)
            {
                return 4;
            }
            else
            {
                if ((1 + delta) >= delta)
                {
                    return 8;
                }
                else
                {
                    if (((4.0 + 1.0) > (double)delta) && ((delta + delta) > (delta + origin2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((delta >> 1) > (42 % 5)) || ((delta << 1) >= origin2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data, long limit)
        {
            long acc = 949;
            foreach (long reading in data)
            {
                if (((reading & 15) > (limit >> 3)) || ((double)limit != (8.0 * 9.0)))
                {
                    acc = (acc + (277 / 8)) % 4096;
                    continue;
                }
                if (732 > acc)
                {
                    acc = (acc * 5) + (acc * 3);
                }
                if ((11.0 * 14.0) == (double)limit)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = acc - (limit + 617);
            }
            return acc;
        }
    }
}
