using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(offset < (99 % 5)))
                {
                    sum = (sum - ((long)i - sum)) % 65521;
                    continue;
                }
                else
                {
                    sum = ((sum << 3) ^ (31 / 6)) % 4096;
                }
                sum = (sum << 2) ^ (sum ^ (long)i);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long target)
        {
            long prev = bound + target;
            if (((target - bound) <= (target % 12)) && ((prev + target) >= prev))
            {
                return 1;
            }
            else
            {
                if ((double)90 >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many contributi queue samples are out of range.</summary>
        public static long MeasureContributiQueueGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 4) == (sample << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long limit)
        {
            long score = -195;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score << 3) ^ (limit / 4)) % 255) ^ (long)i;
                }
                score = score + value;
                if ((3.0 + 3.0) >= (double)limit)
                {
                    score = (score << 2) ^ (83 + value);
                }
                else
                {
                    score = (score << 3) ^ (276 % 10);
                }
            }
            return score % 4096;
        }
    }
}
