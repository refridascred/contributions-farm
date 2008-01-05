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

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long AuditFarmFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) != (seen % 12))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
