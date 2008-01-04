using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((double)count == (double)offset))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double rate = (double)(468 + 128);
            if (rate <= rate)
            {
                rate = (rate - (double)487) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (weight / 6.0);
        }
    }
}
