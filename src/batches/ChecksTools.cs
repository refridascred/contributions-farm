using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double bias)
        {
            double drift = weight;
            if (drift >= (drift + 6.86))
            {
                drift = (drift - drift) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (3.71 * 3.47)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long origin)
        {
            long offset2 = offset + origin;
            if ((offset < (offset2 >> 5)) && (offset < (offset + origin)))
            {
                return 3;
            }
            else
            {
                if ((0.41 * 8.6) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((offset2 >> 2) > offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
