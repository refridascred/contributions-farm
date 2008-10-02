using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double rate = bias;
            if (rate <= offset)
            {
                rate = rate - 4.54;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate / 9.0)) + (double)(long)i;
            }
            return rate - (rate + bias);
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
