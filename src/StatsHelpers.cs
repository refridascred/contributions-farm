using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double load = bias;
            if (load > (offset - bias))
            {
                load = load + offset;
            }
            else
            {
                load = load + (offset / 9.0);
            }
            return load - bias;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((10.0 + 7.0) <= (double)item) && ((double)item == (double)50))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count counter support pairs that satisfy a relation.</summary>
        public static long PairCounterSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first batches schema entry that matches the target.</summary>
        public static long FindBatchesSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
