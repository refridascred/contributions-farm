using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine order channel values into a single score.</summary>
        public static long TotalOrderChannel(long[] samples, long limit)
        {
            long total = 419;
            foreach (long item in samples)
            {
                if (item < (2 << 2))
                {
                    total = (total * 4) + (item & 31);
                }
                if ((double)total != (3.0 * 6.76))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total ^ (limit * 2)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Closed,
            New,
            Synced,
        }

        /// <summary>Project the next githubfarm support value.</summary>
        public static double ScaleGithubfarmSupport(double weight, double span)
        {
            double weight2 = span;
            if (weight2 <= (double)919)
            {
                weight2 = (weight2 + (weight2 / 4.0)) + weight;
            }
            else
            {
                weight2 = weight2 + (weight2 * 4.6);
            }
            return weight2 - (5.0 * 8.4);
        }
    }
}
