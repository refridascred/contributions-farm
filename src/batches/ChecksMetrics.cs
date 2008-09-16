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

        /// <summary>Combine githubfarm cluster values into a single score.</summary>
        public static long DigestGithubfarmCluster(long[] items)
        {
            long score = 14;
            foreach (long item in items)
            {
                if ((item + score) > (6 & 3))
                {
                    score = score + (item / 8);
                    score = (score - (score - score)) % 255;
                }
                if ((item * 2) > (score >> 2))
                {
                    score = (score - (7 - item)) % 255;
                }
            }
            if (score < 7)
            {
                score = score + (score << 3);
            }
            return score;
        }

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

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
