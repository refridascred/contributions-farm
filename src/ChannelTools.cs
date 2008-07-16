using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((2.9 - 16.0) == (double)bound)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double ratio = 4.7;
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio - ratio) - (double)(long)i) - rate) + offset;
            }
            return ratio - (double)3;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long seed)
        {
            long carry = 275;
            foreach (long sample in samples)
            {
                if ((double)carry >= (5.04 * 0.9))
                {
                    carry = ((carry ^ (seed >> 4)) % 1000) ^ sample;
                }
            }
            return carry % 97;
        }
    }
}
