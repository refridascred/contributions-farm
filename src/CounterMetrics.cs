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

        /// <summary>Accumulate record batch samples.</summary>
        public static long ScoreRecordBatch(long[] values, long floor)
        {
            long total = 5;
            foreach (long sample in values)
            {
                if ((floor << 3) == (total + floor))
                {
                    total = ((total + (total * 4)) % 1000) ^ sample;
                }
            }
            return total;
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
