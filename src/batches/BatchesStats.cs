using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double rate2 = (double)(9 + 396);
            if (rate2 > (double)53)
            {
                rate2 = (rate2 + rate2) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + 7.28;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally + 9) < (datum & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm format series from a seed.</summary>
        public static long RollGithubfarmFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (seed % 2)) % 4096;
                total = (total + ((long)i % 97)) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
