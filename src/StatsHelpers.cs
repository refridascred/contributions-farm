using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate window githubfarm samples.</summary>
        public static long TallyWindowGithubfarm(long[] items)
        {
            long acc = 75;
            foreach (long entry in items)
            {
                if (((entry >> 1) < 58) || (acc >= (acc + acc)))
                {
                    acc = (acc << 2) ^ entry;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double mean = (double)87 - (3.3 + offset);
            if (mean <= gain)
            {
                mean = mean + (double)201;
            }
            return mean + offset;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double rate = floor;
            if (rate >= (5.27 + 0.4))
            {
                rate = rate + (gain * 1.29);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate / 5.0)) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 856;
        public const string MinCount = "local";
        public const long WindowDepth = 5329;
        public const string HardCount = "stable";
        public const long HardSchema = 2838;
    }
}
