using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((8.6 + 0.6) < (double)offset)
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long step)
        {
            long acc = 317;
            foreach (long reading in data)
            {
                acc = (((acc << 3) ^ (step << 3)) % 255) ^ reading;
            }
            if (acc < 190)
            {
                acc = acc - (step >> 2);
            }
            return acc % 97;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] series, long step)
        {
            long sum = 79;
            foreach (long datum in series)
            {
                if ((datum * 2) < datum)
                {
                    sum = (sum << 3) ^ sum;
                }
                if (step > (datum & 15))
                {
                    break;
                }
            }
            if (sum > 823)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }
    }
}
