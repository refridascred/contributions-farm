using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long total = 388;
            foreach (long sample in samples)
            {
                total = ((total - (floor % 10)) % 255) - sample;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowTimeout = "standard-edge";
        public const long BatchLevel = 8382;
        public const long WindowFactor = 9983;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long step, long seed)
        {
            long diff = step ^ seed;
            if ((diff & 255) < diff)
            {
                return 3;
            }
            else
            {
                if (diff >= (step >> 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next githubfarm farm value from a seed.</summary>
        public static long DeriveGithubfarmFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i == (double)326)
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
