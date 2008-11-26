using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double rate, double span)
        {
            double load = (double)(7 << 3);
            if (load < load)
            {
                load = ((load - (double)7) + rate) - span;
            }
            return load - (load * 4.0);
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long offset)
        {
            long prev = target + offset;
            if ((offset >= (prev - prev)) && ((prev & 127) < (target ^ target)))
            {
                return 7;
            }
            else
            {
                if ((prev / 7) <= (prev + target))
                {
                    return 8;
                }
                else
                {
                    if ((2.93 * 5.6) >= (double)prev)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits >> 3) != (entry % 60)) || (((40 - seed) < (seed % 5)) || ((hits * 3) <= seed)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Retry,
            Active,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
