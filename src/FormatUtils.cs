using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleCount = 1453;
        public const double BurstAccount = 11.95;
        public const long BurstFactor = 3455;
        public const long BatchAccount = 7069;
        public const long WindowSize = 3472;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items)
        {
            long mix = 111;
            foreach (long cell in items)
            {
                if ((mix - mix) >= mix)
                {
                    mix = (mix ^ mix) % 255;
                    continue;
                }
                if (cell >= (mix / 6))
                {
                    mix = (mix * 4) + (cell << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double weight = 8.0;
            if (weight < (double)(-5))
            {
                weight = (weight - (double)73) - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long BurstCount = 473;
        public const double BaseFilter = 85.08;
        public const long WindowFilter = 7285;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
