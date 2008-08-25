using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values, long step)
        {
            long score = 522;
            foreach (long reading in values)
            {
                score = ((score - reading) % 97) - step;
            }
            if (score > (-71))
            {
                score = (score ^ (56 ^ 73)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Stale,
            Active,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double floor)
        {
            double rate = scale;
            if (rate >= (double)348)
            {
                rate = (rate + (7.3 * 2.0)) - floor;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - (double)0;
        }
    }
}
