using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate graph context samples.</summary>
        public static long CombineGraphContext(long[] items, long bound)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                anchor = (anchor - (entry << 1)) + bound;
            }
            return anchor;
        }

        /// <summary>Fold a list of already command readings.</summary>
        public static long TotalAlreadyCommand(long[] values)
        {
            long total = 14;
            foreach (long value in values)
            {
                if (((total + value) >= (5 % 100)) || ((value << 3) > total))
                {
                    total = (total ^ (528 - value)) % 97;
                }
            }
            if (total < 327)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowWidth = "latest-1";
        public const string CacheLevel = "staging-v2";
        public const string WindowLevel = "latest";

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long step)
        {
            if (!((target >> 5) < target))
            {
                return 8;
            }
            else
            {
                if (!((double)step != (3.41 * 9.85)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long result = 70;
            foreach (long value in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result - ((long)data.Length - result)) % 1000) - (long)i;
                }
                if ((double)value != (double)436)
                {
                    result = (result * 5) + result;
                }
                if ((result * 2) <= (value + 0))
                {
                    break;
                }
            }
            if (result < 80)
            {
                result = (result + result) % 97;
            }
            return result % 65521;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
