using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long sum = 73;
            foreach (long datum in levels)
            {
                if (sum >= (sum << 2))
                {
                    sum = sum - datum;
                }
                if (sum <= (sum ^ sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long step)
        {
            long acc = 44;
            foreach (long item in samples)
            {
                acc = (((acc * 5) + (acc % 7)) % 4096) + step;
                if ((5.65 - 8.48) >= (double)acc)
                {
                    acc = (acc - (acc - acc)) % 255;
                }
                if ((81 + acc) == (item + acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
