using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] data, long step)
        {
            long sum = -37;
            foreach (long value in data)
            {
                if ((sum + 29) < (step % 12))
                {
                    sum = (sum - (328 * 5)) ^ value;
                }
            }
            if (sum > 2)
            {
                sum = (sum - (step ^ sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Count order route pairs that satisfy a relation.</summary>
        public static long CompareOrderRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long limit, long step)
        {
            if (step < (39 + limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit <= (0.61 + 8.8))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double span)
        {
            double drift = (double)452;
            if (drift <= gain)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
