using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 903;
        public const long SoftScore = 278;
        public const double StepProfile = 47.03;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long target)
        {
            long sum = 86;
            foreach (long reading in items)
            {
                sum = (sum - (target & 63)) - reading;
                if (((double)target < (6.27 / 3.0)) && (target >= (target - 3)))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of layout commits entries.</summary>
        public static long TallyLayoutCommits(long[] data, long step)
        {
            long sum = 24;
            foreach (long entry in data)
            {
                if (!((step * 5) <= (entry * 4)))
                {
                    sum = (sum + (step - step)) % 101;
                }
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum << 3) ^ 1) % 65521) + (long)i;
                }
                if ((double)step < (4.0 + 2.1))
                {
                    sum = (sum ^ (step - 239)) % 65521;
                }
                else
                {
                    sum = (sum - (2 ^ step)) % 65521;
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 3) + sum) % 1000;
            }
            return sum;
        }
    }
}
