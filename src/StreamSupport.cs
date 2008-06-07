using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry - seen) <= (seen >> 2)) || ((bound < (entry + bound)) || (9.0 >= (double)bound)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics session pair into a bucket.</summary>
        public static long ClassifyMetricsSession(long offset, long bound)
        {
            if ((bound + bound) > (bound + offset))
            {
                return 6;
            }
            else
            {
                if (71 <= bound)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 5) + (limit / 2);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
