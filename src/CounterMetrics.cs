using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry * 4) + carry) % 255) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long target, long floor)
        {
            if (((floor % 60) != (target >> 1)) || ((target >> 5) <= target))
            {
                return 5;
            }
            else
            {
                if (!((target >> 2) < (9 - target)))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 4) < (441 >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 2) == (112 ^ (-209)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((target * 2) < (251 ^ 8))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
