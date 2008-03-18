using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate order channel samples.</summary>
        public static long CombineOrderChannel(long[] items)
        {
            long carry = 632;
            foreach (long item in items)
            {
                if ((carry % 24) > (507 ^ item))
                {
                    carry = ((carry * 5) + (carry ^ item)) % 101;
                }
                else
                {
                    carry = carry + (item + item);
                }
            }
            return carry;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long offset)
        {
            if (!((double)step != (6.0 - 3.56)))
            {
                return 7;
            }
            else
            {
                if (!(5.5 <= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (2.45 <= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if (9.5 <= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
