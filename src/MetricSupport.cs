using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((((long)i % 12) != (origin * 2)) || ((score + score) >= ((long)i >> 2)))
                {
                    score = (score - (score >> 1)) % 4096;
                    score = (score << 3) ^ ((long)i * 4);
                }
                score = (score ^ score) % 101;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
