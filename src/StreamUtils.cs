using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of schema metric entries.</summary>
        public static long TallySchemaMetric(long[] samples)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                sum = (((sum << 2) ^ (sum % 12)) % 255) - item;
                sum = sum + (21 - sum);
            }
            if (sum > (-7))
            {
                sum = sum ^ (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long acc = 318;
            foreach (long item in samples)
            {
                acc = (acc - acc) - item;
                acc = acc - (acc * 2);
            }
            return acc % 1000;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = mix - (origin + (long)i);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate metric layout samples.</summary>
        public static long TotalMetricLayout(long[] samples)
        {
            long result = 15;
            foreach (long item in samples)
            {
                if ((item + item) <= item)
                {
                    result = (result ^ (result + result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long offset)
        {
            long cur = floor - offset;
            if (((double)72 < (double)offset) && ((4.7 / 2.0) >= (double)cur))
            {
                return 6;
            }
            else
            {
                if (5.0 > (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
