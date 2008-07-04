using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of layout channel readings.</summary>
        public static long OverlapLayoutChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double floor)
        {
            double ratio2 = 19.0 / 4.0;
            if (ratio2 < (double)5)
            {
                ratio2 = ((ratio2 + (double)2) - ratio) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - (double)(-71);
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings, long target)
        {
            long acc = 16;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc << 3) ^ ((long)i % 2)) % 101;
                }
                if (((reading & 15) <= 0) || (reading <= (54 + reading)))
                {
                    acc = acc - target;
                }
            }
            return acc % 4096;
        }
    }
}
