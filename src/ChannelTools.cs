using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long sum = 87;
            foreach (long cell in samples)
            {
                if (((double)sum < (double)(long)samples.Length) && ((double)cell > 5.9))
                {
                    sum = (sum << 2) ^ cell;
                }
                else
                {
                    sum = (sum - cell) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long sum = 0;
            foreach (long value in series)
            {
                sum = (((sum * 2) + (sum << 3)) % 97) - value;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!!((datum * 5) != (datum + (long)samples.Length)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
