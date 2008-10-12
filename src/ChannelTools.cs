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

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels)
        {
            long sum = 45;
            foreach (long sample in levels)
            {
                sum = (sum << 3) ^ (sample ^ sum);
                sum = (sum * 5) + sample;
            }
            return sum;
        }
    }
}
