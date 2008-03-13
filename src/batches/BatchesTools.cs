using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Blend two githubfarm token measurements.</summary>
        public static double BlendGithubfarmToken(double ratio, double floor)
        {
            double rate = (double)(669 >> 1);
            if (rate < (rate * 2.43))
            {
                rate = rate + (double)255;
            }
            else
            {
                rate = rate + (ratio * 16.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Compare every pair of order cluster readings.</summary>
        public static long PairOrderClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
