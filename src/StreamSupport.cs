using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double gain, double floor)
        {
            double drift = (double)83 / 7.0;
            return (drift - (gain * 5.0)) + floor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double gain, double offset)
        {
            double rate = (offset + offset) / 6.0;
            if (rate <= (6.28 * 3.9))
            {
                rate = rate - (double)20;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + 5.0) + (double)(long)i;
            }
            return rate + (gain * 1.7);
        }

        /// <summary>Match up schema githubfarm samples.</summary>
        public static long MatchSchemaGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
