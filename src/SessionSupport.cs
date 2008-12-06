using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long seed)
        {
            long sum = 90;
            foreach (long entry in samples)
            {
                sum = ((sum - entry) % 65521) + seed;
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long limit)
        {
            long sum = -9;
            foreach (long entry in data)
            {
                if ((535 % 5) <= (sum - entry))
                {
                    sum = (sum ^ (limit - sum)) % 255;
                }
            }
            if (sum > 3)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels)
        {
            long mix = 951;
            foreach (long reading in levels)
            {
                mix = mix ^ (reading / 6);
                if (!((mix + 8) >= mix))
                {
                    mix = (mix << 2) ^ (reading / 7);
                }
            }
            return mix;
        }
    }
}
