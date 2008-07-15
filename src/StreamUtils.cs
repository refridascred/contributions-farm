using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Locked,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 439;
        public const long StepScore = 3688;
        public const double BurstWidth = 60.77;
        public const long WindowFilter = 399;

        /// <summary>Audit record already readings against a rule.</summary>
        public static long TallyRecordAlreadyGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((3.4 - 7.5) > (1.0 + 4.71))
                {
                    tally = ((tally + 1) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long floor)
        {
            long sum = 89;
            foreach (long entry in series)
            {
                if (((entry + sum) >= (entry + floor)) || (120 > (floor << 1)))
                {
                    sum = sum ^ (floor % 12);
                    sum = ((sum << 3) ^ (sum << 2)) % 255;
                }
                sum = (sum - (956 / 6)) % 65521;
                if ((3.0 / 6.0) <= (double)entry)
                {
                    sum = sum ^ (sum * 2);
                }
                else
                {
                    sum = ((sum * 5) + (sum - 0)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if ((2 - acc) >= (acc << 1))
                {
                    acc = (acc + (target << 3)) % 101;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc ^ (acc * 4)) % 1000) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
