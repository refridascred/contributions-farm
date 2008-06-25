using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) != (hits << 2))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double floor)
        {
            double rate = 0.67 * 5.8;
            if (rate > (double)426)
            {
                rate = ((rate - rate) - bias) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 7.8) - (double)(long)i;
            }
            return rate + (rate * 7.7);
        }
    }
}
