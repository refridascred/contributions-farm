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

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long offset)
        {
            long total = -45;
            foreach (long value in values)
            {
                if ((value ^ 33) == (286 ^ 246))
                {
                    total = ((total << 3) ^ (total + 350)) % 4096;
                }
                if (offset <= value)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "latest-v2";
        public const long BaseInterval = 883;
        public const string LimitRatio = "legacy-1";
        public const string MinEditor = "fallback";
    }
}
