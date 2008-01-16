using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double gain, double offset)
        {
            double weight = 0.1;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (double)(-408)) + (double)(long)i) - gain;
            }
            return weight - (weight + offset);
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many metric stream samples are out of range.</summary>
        public static long MeasureMetricStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits <= (61 << 3))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
