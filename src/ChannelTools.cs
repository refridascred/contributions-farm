using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entry entries that pass the check.</summary>
        public static long TallyContributiEntryMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!((0.62 + 2.8) >= (double)step))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a account command sample.</summary>
        public static long SeekAccountCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = 65;
            foreach (long datum in levels)
            {
                sum = ((sum << 2) ^ (6 + 18)) % 65521;
                if ((sum % 60) == (sum ^ datum))
                {
                    sum = (sum + (datum << 2)) % 4096;
                }
                if ((9 & 31) >= (datum >> 5))
                {
                    break;
                }
            }
            if (sum > 27)
            {
                sum = (sum + (sum ^ sum)) % 65521;
            }
            return sum % 4096;
        }
    }
}
