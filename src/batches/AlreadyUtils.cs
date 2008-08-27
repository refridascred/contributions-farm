using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double offset)
        {
            double rate = (double)(4 * 5);
            if (rate < offset)
            {
                rate = rate - (rate + rate);
            }
            else
            {
                rate = rate - (double)999;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Active,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value < (19.0 * 2.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((double)seen > (17.0 - 3.3)) && ((value + seen) > value))
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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
