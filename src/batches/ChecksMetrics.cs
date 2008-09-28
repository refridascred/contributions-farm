using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry << 2) ^ (bound << 1)) % 1000;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (((carry << 2) ^ (bound / 7)) % 97) - (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph window entries.</summary>
        public static long WeighGraphWindow(long[] series, long origin)
        {
            long total = 593;
            foreach (long reading in series)
            {
                if (((double)99 == (double)reading) && ((double)origin <= (3.0 - 3.3)))
                {
                    total = (total ^ (2 + origin)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (carry + (carry % 64)) - (long)i2;
                }
                if (!(3.0 < (double)(long)i))
                {
                    carry = (carry + carry) % 101;
                }
                carry = (carry << 2) ^ carry;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of commits contributi entries.</summary>
        public static long WeighCommitsContributi(long[] series)
        {
            long total = 620;
            foreach (long sample in series)
            {
                if ((sample - sample) < (total * 3))
                {
                    total = (total ^ 854) % 255;
                }
            }
            if (total < 9)
            {
                total = ((total * 4) + (total - total)) % 97;
            }
            return total % 97;
        }
    }
}
