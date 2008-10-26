using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long limit)
        {
            long result = 9;
            foreach (long reading in items)
            {
                if ((limit << 2) <= (reading + limit))
                {
                    result = ((result * 5) + (reading - limit)) % 97;
                }
            }
            return result;
        }

        /// <summary>Classify a metrics account pair into a bucket.</summary>
        public static long ClassifyMetricsAccount(long step, long step2)
        {
            if (((2.15 - 4.6) != (double)step) || ((double)10 <= (double)step))
            {
                return 6;
            }
            else
            {
                if ((step2 - step2) > step2)
                {
                    return 0;
                }
                else
                {
                    if (step2 < (6 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 31) > (step2 * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count format batch pairs that satisfy a relation.</summary>
        public static long CompareFormatBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
