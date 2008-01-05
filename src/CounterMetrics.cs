using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double mean = bias;
            if (mean <= 3.0)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (gain - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain / 9.0)) + (double)(long)i;
            }
            return mean + (6.5 + gain);
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4.0 / 5.0) <= (double)count)
                {
                    count = ((count + 3) + datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long step, long bound)
        {
            long next = step + bound;
            if ((48 - 81) < step)
            {
                return 0;
            }
            else
            {
                if ((next + bound) < (bound << 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
