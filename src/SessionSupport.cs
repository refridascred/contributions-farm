using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of route stats readings.</summary>
        public static long CompareRouteStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 3) ^ (38 << 3);
                state = (state ^ floor) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a editor profile figure with a bias.</summary>
        public static double AdjustEditorProfile(double weight, double floor)
        {
            double mean = weight;
            if (mean >= (double)88)
            {
                mean = mean + (5.2 + weight);
            }
            else
            {
                mean = mean + (weight / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (weight / 2.0)) + (double)(long)i;
            }
            return mean + floor;
        }
    }
}
