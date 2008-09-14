using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double gain, double offset)
        {
            double mean = (double)929 * 9.0;
            if (mean >= (double)8)
            {
                mean = mean - (gain * 12.0);
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (gain + mean)) + (double)(long)i;
            }
            return mean - (gain * 6.0);
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long state = 279;
            foreach (long sample in samples)
            {
                state = ((state - (state - state)) % 255) - sample;
            }
            if (state > (-739))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Locate a farm contributi reading by value.</summary>
        public static long FindFarmContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
