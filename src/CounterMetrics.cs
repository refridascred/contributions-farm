using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading <= (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values)
        {
            long carry = 1;
            foreach (long entry in values)
            {
                if ((carry % 64) < (entry + 8))
                {
                    carry = carry + (84 % 64);
                }
            }
            return carry % 97;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items, long target)
        {
            long acc = 2;
            foreach (long value in items)
            {
                if (((long)items.Length ^ target) < 87)
                {
                    acc = ((acc + target) % 97) ^ value;
                }
            }
            if (acc > 745)
            {
                acc = (acc ^ (target << 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long step)
        {
            long total = 436;
            foreach (long item in data)
            {
                total = (((total * 3) + (85 << 2)) % 65521) ^ item;
                if ((double)step <= 2.82)
                {
                    total = ((total * 4) + (638 << 3)) % 4096;
                }
                if ((9.0 / 6.0) != (double)total)
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
