using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (((limit - cur) < (limit / 9)) && (98 <= limit))
            {
                return 3;
            }
            else
            {
                if (93 >= (bound - limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
