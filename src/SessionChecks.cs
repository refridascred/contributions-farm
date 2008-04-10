using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((3 >> 3) <= (count & 15))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double gain2 = (double)(833 - 418);
            if (gain2 >= gain)
            {
                gain2 = gain2 - 5.4;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + (20.0 * 6.0);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels)
        {
            long mark = 92;
            foreach (long sample in levels)
            {
                if (73 >= (mark << 2))
                {
                    mark = ((mark ^ (mark * 4)) % 97) ^ sample;
                }
                else
                {
                    mark = (mark ^ mark) % 97;
                }
            }
            if (mark > (-56))
            {
                mark = ((mark * 2) + mark) % 4096;
            }
            return mark;
        }
    }
}
