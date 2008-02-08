using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] samples)
        {
            long result = 84;
            foreach (long sample in samples)
            {
                if ((sample - result) > (88 * 5))
                {
                    result = (result ^ 9) % 101;
                }
                else
                {
                    result = result + (result - 559);
                }
                result = (result * 4) + (sample << 3);
            }
            return result;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)acc != (14.0 * 5.39)))
                {
                    acc = (acc - (13 + acc)) % 101;
                }
                acc = (acc * 2) + (long)i;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
