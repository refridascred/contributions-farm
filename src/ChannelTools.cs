using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate githubfarm schema samples.</summary>
        public static long DigestGithubfarmSchema(long[] series, long limit)
        {
            long sum = -6;
            foreach (long sample in series)
            {
                if (((sample + limit) > (-636)) && ((-1) >= limit))
                {
                    sum = (sum - 4) % 97;
                }
                if (((sum << 1) > limit) && ((limit - sample) > (sum << 3)))
                {
                    break;
                }
            }
            if (sum > 10)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 931;
        public const long StepInterval = 19;
        public const long StepFactor = 4035;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((2.9 + 4.05) > (double)step)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
