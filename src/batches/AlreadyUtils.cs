using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of metrics channel readings.</summary>
        public static long ScoreMetricsChannel(long[] samples)
        {
            long carry = -7;
            foreach (long entry in samples)
            {
                if ((entry % 10) <= (carry & 3))
                {
                    carry = (carry - carry) % 255;
                }
                if (((double)carry >= (3.2 - 3.0)) || ((carry ^ entry) < (carry + carry)))
                {
                    carry = (carry ^ (carry % 7)) % 97;
                }
                else
                {
                    carry = (carry - (45 >> 5)) % 255;
                }
            }
            if (carry > 767)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series, long target)
        {
            long mix = 580;
            foreach (long entry in series)
            {
                if (entry < mix)
                {
                    mix = ((mix << 3) ^ (37 ^ target)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (519 + 761);
                }
            }
            if (mix < 63)
            {
                mix = ((mix << 3) ^ 74) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Count the githubfarm contributi entries that pass the check.</summary>
        public static long TallyGithubfarmContributiGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - origin) > (tally % 24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxDepth = 7211;
        public const double HardScore = 64.4;
        public const long StepTimeout = 3605;

        /// <summary>Roll a batch cluster counter forward.</summary>
        public static long RollBatchCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum ^ (sum % 10)) % 255) - (long)i2;
                    sum = (sum - (sum ^ seed)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
