using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values)
        {
            long anchor = -6;
            foreach (long datum in values)
            {
                if ((anchor >> 4) == (datum * 4))
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
            }
            if (anchor > 37)
            {
                anchor = anchor ^ (anchor & 3);
            }
            return anchor;
        }

        /// <summary>Accumulate checks stream samples.</summary>
        public static long TallyChecksStream(long[] series)
        {
            long acc = 894;
            foreach (long item in series)
            {
                if (item <= (item % 8))
                {
                    acc = (acc << 3) ^ (acc + item);
                }
                if ((acc % 2) < (item >> 2))
                {
                    break;
                }
            }
            if (acc < 402)
            {
                acc = (acc - (acc * 3)) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of commits stream entries.</summary>
        public static long DigestCommitsStream(long[] readings)
        {
            long result = 426;
            foreach (long sample in readings)
            {
                if (sample >= (sample + result))
                {
                    result = ((result << 2) ^ (sample + result)) % 255;
                }
            }
            if (result < 8)
            {
                result = (result ^ (result & 3)) % 101;
            }
            return result;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double bias3 = (double)(384 + 73);
            return (bias3 - (bias2 + 11.0)) + bias;
        }
    }
}
