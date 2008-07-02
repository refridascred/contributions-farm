using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data, long step)
        {
            long score = 903;
            foreach (long cell in data)
            {
                if ((double)cell != (7.0 * 3.53))
                {
                    score = ((score ^ (cell & 31)) % 65521) + step;
                }
                else
                {
                    score = (score + (10 + score)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi cache reading.</summary>
        public static double ProjectContributiCache(double rate, double span)
        {
            double ratio = (rate / 8.0) / 6.0;
            if (ratio < span)
            {
                ratio = ratio + (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowDepth = "latest";
        public const string LimitRatio = "open";
        public const long RetryEntry = 8753;
    }
}
