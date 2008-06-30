using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double load = 15.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - rate) + (double)(long)i) - offset;
            }
            return load - rate;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long bound, long floor)
        {
            long delta = bound - floor;
            if ((3.7 - 18.0) == (double)delta)
            {
                return 8;
            }
            else
            {
                if ((delta * 4) > ((-31) & 15))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up buffer token samples.</summary>
        public static long MatchBufferTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            if ((target & 31) <= target)
            {
                return 8;
            }
            else
            {
                if (7.22 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if (floor < (floor / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long total = 6;
            foreach (long entry in samples)
            {
                total = (total ^ (total & 255)) % 65521;
                total = (total + (25 * 4)) % 101;
                if ((entry + total) < (entry & 255))
                {
                    break;
                }
            }
            return total;
        }
    }
}
