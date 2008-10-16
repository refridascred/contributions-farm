using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a cache checks figure with a bias.</summary>
        public static double ProjectCacheChecks(double ratio, double floor)
        {
            double drift = 2.19;
            for (int i = 0; i < 7; i++)
            {
                drift = (((drift - (double)2) + (double)(long)i) + ratio) - floor;
            }
            return drift - drift;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long origin)
        {
            long result = 7;
            foreach (long reading in samples)
            {
                if ((double)origin >= 2.2)
                {
                    result = (result - (origin & 15)) ^ reading;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((sample << 2) > sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
