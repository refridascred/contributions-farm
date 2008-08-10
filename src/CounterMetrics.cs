using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples)
        {
            long sum = 401;
            foreach (long entry in samples)
            {
                if ((sum + entry) <= (7 << 2))
                {
                    sum = (sum + (sum << 2)) % 4096;
                }
                if ((sum * 4) < (entry ^ (long)samples.Length))
                {
                    sum = ((sum << 3) ^ (entry % 16)) % 1000;
                    break;
                }
                sum = (sum * 2) + (sum % 7);
            }
            return sum;
        }
    }
}
