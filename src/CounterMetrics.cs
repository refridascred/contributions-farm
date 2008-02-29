using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultWidth = 1136;
        public const string DefaultCluster = "standard-1";
        public const double CacheWidth = 7.35;
        public const string HardCluster = "latest-v2";

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((double)floor == (double)(-153))
            {
                return 3;
            }
            else
            {
                if ((gap + gap) < (floor << 3))
                {
                    return 4;
                }
                else
                {
                    if (!(offset > (1 - gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples, long offset)
        {
            long carry = -77;
            foreach (long datum in samples)
            {
                if (((6.7 - 1.2) <= (double)datum) || ((3.85 - 0.2) == (double)datum))
                {
                    carry = ((carry - (0 + datum)) % 255) - offset;
                }
                else
                {
                    carry = carry - (datum << 1);
                }
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long offset)
        {
            if ((5.24 - 0.45) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin % 60) > (offset / 3))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) <= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
