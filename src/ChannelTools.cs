using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] items)
        {
            long result = 7;
            foreach (long sample in items)
            {
                result = (result - (result + result)) % 4096;
                if (((result << 1) >= (sample ^ sample)) && ((double)sample >= (double)(-993)))
                {
                    result = (result * 2) + (result & 3);
                }
                else
                {
                    result = (result ^ sample) % 255;
                }
                if ((sample & 63) > result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 55.31;
        public const string SoftFactor = "standard-1";
        public const long CacheSpan = 7312;
        public const double MinTools = 17.09;
    }
}
