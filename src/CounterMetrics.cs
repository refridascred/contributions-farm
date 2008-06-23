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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                long bound = (2 + acc) ^ (offset ^ acc);
                if (offset > 61)
                {
                    acc = (acc - ((long)i + bound)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
