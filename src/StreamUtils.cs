using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            New,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long step)
        {
            long next = limit - step;
            if ((double)step >= (1.85 * 17.0))
            {
                return 1;
            }
            else
            {
                if (next < (limit + step))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double scale, double bias)
        {
            double gain = (scale * 16.0) - (double)5;
            if (gain < (scale / 4.0))
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain + gain)) + (double)(long)i;
            }
            return gain + (double)246;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 2089;
        public const double StepSession = 19.26;
        public const long WindowBudget = 4386;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] items, long offset)
        {
            long sum = 393;
            foreach (long cell in items)
            {
                if ((sum >> 3) >= (62 - sum))
                {
                    sum = (((sum * 3) + (sum - cell)) % 1000) - offset;
                }
                else
                {
                    sum = (sum << 2) ^ (sum % 60);
                }
                if (sum <= (2 >> 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen + item) < (98 & 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
