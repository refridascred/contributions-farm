using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long offset, long offset2)
        {
            long cur = offset ^ offset2;
            if ((cur * 3) > (offset2 + 593))
            {
                return 8;
            }
            else
            {
                if ((1.9 + 0.64) < (double)cur)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset == (double)offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 3276;
        public const long DefaultSpan = 2186;
        public const long BurstSupport = 6640;
        public const long IdleSpan = 7280;
        public const string LimitCount = "strict-v2";
    }
}
