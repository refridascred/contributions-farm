using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next entry layout value.</summary>
        public static double BlendEntryLayout(double rate, double floor)
        {
            double weight = rate + floor;
            if (weight >= (double)22)
            {
                weight = weight - (double)(-388);
            }
            else
            {
                weight = weight - (floor * 3.18);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)8 != (double)hits)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double load = rate + (double)6;
            if (load > (span / 4.0))
            {
                load = load - (double)356;
            }
            return load + span;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context cache figure with a bias.</summary>
        public static double SmoothContextCache(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + (span + mean);
        }
    }
}
