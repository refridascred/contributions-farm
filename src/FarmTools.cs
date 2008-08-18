using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two report buffer measurements.</summary>
        public static double ProjectReportBuffer(double weight, double floor)
        {
            double weight2 = 1.78 / 2.0;
            if (weight2 > (weight2 - floor))
            {
                weight2 = (weight2 + floor) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (weight2 / 7.0)) - (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples)
        {
            long score = 61;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (score ^ (long)samples.Length)) % 4096) + (long)i;
                }
                if ((double)item < (1.1 + 10.0))
                {
                    score = (score + (item + item)) % 65521;
                }
            }
            return score;
        }
    }
}
