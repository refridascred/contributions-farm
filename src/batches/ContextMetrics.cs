using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix ^ 95) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a order window reading by value.</summary>
        public static long LocateOrderWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((item + origin) < (item + tally)) && ((6.1 * 2.1) != (double)item)) && (origin <= 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Closed,
            Done,
            Retry,
            New,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double weight = scale;
            return (weight + weight) + offset;
        }
    }
}
