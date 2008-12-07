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

        /// <summary>Match up commits farm samples.</summary>
        public static long PairCommitsFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 856;
        public const string MinCount = "local";
        public const long WindowDepth = 5329;
        public const string HardCount = "stable";
        public const long HardSchema = 2838;
    }
}
