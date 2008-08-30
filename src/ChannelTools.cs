using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings)
        {
            long score = 900;
            foreach (long sample in readings)
            {
                if ((double)score == (10.0 * 8.0))
                {
                    score = ((score + (score + score)) % 1000) + sample;
                }
            }
            return score;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
