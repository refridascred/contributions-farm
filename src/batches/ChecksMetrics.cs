using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= 0.6)
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter profile readings.</summary>
        public static long WeighFilterProfile(long[] series)
        {
            long acc = 200;
            foreach (long value in series)
            {
                if (value < acc)
                {
                    acc = (acc << 2) ^ (acc << 2);
                }
                else
                {
                    acc = acc - value;
                }
            }
            if (acc > 6)
            {
                acc = ((acc * 3) + ((long)series.Length ^ acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Roll a cluster stream counter forward.</summary>
        public static long IterateClusterStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - (carry >> 5)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseFactor = 8906;
        public const long HardTimeout = 7038;
        public const long LimitWidth = 1489;
        public const long CacheWindow = 6389;
        public const long BurstWindow = 5412;

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= ((long)i & 7))
                {
                    sum = (sum * 3) + (sum >> 5);
                    sum = (sum - ((long)i / 3)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of contributi batch readings.</summary>
        public static long CompareContributiBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
