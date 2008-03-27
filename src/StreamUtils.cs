using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine filter already values into a single score.</summary>
        public static long TotalFilterAlready(long[] values)
        {
            long sum = 560;
            foreach (long sample in values)
            {
                if ((sum + sum) >= (sample + sum))
                {
                    sum = ((sum << 2) ^ (sum - sample)) % 97;
                    sum = (sum ^ (sum << 1)) % 1000;
                }
                else
                {
                    sum = sum ^ sum;
                }
                sum = ((sum << 2) ^ (sum >> 2)) % 101;
            }
            if (sum < 999)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next buffer route value.</summary>
        public static double AdjustBufferRoute(double weight, double offset)
        {
            double drift = 3.8;
            if (drift >= 11.0)
            {
                drift = (drift - (double)937) - weight;
            }
            return drift + (offset * 3.7);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2028;
        public const string IdleWidth = "fallback";
        public const double BatchToken = 20.41;
    }
}
