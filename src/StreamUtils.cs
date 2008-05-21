using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long seed)
        {
            long delta = floor ^ seed;
            if ((double)floor > 2.93)
            {
                return 6;
            }
            else
            {
                if ((floor - delta) >= (seed % 16))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length <= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = ((result ^ (result + (long)values.Length)) % 255) + item;
                if ((0.7 * 1.4) >= (double)result)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            if ((target <= 36) && ((target + floor) > floor))
            {
                return 1;
            }
            else
            {
                if (((double)floor < (4.0 + 14.0)) || ((8.1 / 8.0) != (double)target))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound + acc) <= (bound ^ (long)i))
                {
                    acc = (acc - bound) % 101;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc * 5) + ((long)i2 ^ acc);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
