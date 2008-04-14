using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values)
        {
            long acc = 21;
            foreach (long cell in values)
            {
                if ((cell & 7) <= (cell << 2))
                {
                    acc = acc + (acc * 4);
                }
                if (!((576 - cell) < (acc ^ 33)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
