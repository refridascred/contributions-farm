using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine schema already values into a single score.</summary>
        public static long CombineSchemaAlready(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if ((offset * 3) > value)
                {
                    sum = (sum ^ 87) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                sum = sum - (offset >> 2);
            }
            return sum;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
