using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank record entry input into a small class.</summary>
        public static long SortRecordEntry(long limit, long bound)
        {
            if (((bound << 3) < (bound - 773)) && ((limit - 57) <= limit))
            {
                return 2;
            }
            else
            {
                if (((21 / 5) > limit) && ((bound + bound) != (bound - limit)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > 8.35)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)limit >= (6.0 - 6.0)) || ((limit ^ limit) == (bound * 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a entry metric counter forward.</summary>
        public static long StepEntryMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if (floor >= acc)
                {
                    acc = (acc << 3) ^ ((long)i << 2);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double gain, double span)
        {
            double mean = (double)(4 / 5);
            if (mean > (mean * 5.46))
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + gain;
            }
            return mean - span;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
