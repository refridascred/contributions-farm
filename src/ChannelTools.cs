using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 2) ^ (bound + (long)i)) % 1000;
                if (!((2.9 * 5.84) < (double)sum))
                {
                    sum = sum ^ sum;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum - (bound + sum)) % 1000) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen <= (sample / 5))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
