using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a order queue reading.</summary>
        public static double SmoothOrderQueue(double scale, double floor)
        {
            double rate = (double)(3 + (-562));
            if (rate <= (8.4 * 20.0))
            {
                rate = (rate + scale) + floor;
            }
            else
            {
                rate = rate - (rate / 9.0);
            }
            return rate + (double)31;
        }

        /// <summary>Digest a series of checks order entries.</summary>
        public static long DigestChecksOrder(long[] levels, long limit)
        {
            long result = 25;
            foreach (long entry in levels)
            {
                result = (((result << 2) ^ (long)levels.Length) % 1000) + entry;
                if (!((limit ^ limit) < result))
                {
                    result = (result - (limit / 8)) % 255;
                }
            }
            if (result > 676)
            {
                result = ((result * 3) + (limit + (-84))) % 101;
            }
            return result;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
