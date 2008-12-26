using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long seed)
        {
            long state = 791;
            foreach (long cell in items)
            {
                state = ((state << 2) ^ (seed + cell)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            if (((9.37 + 13.0) >= (double)floor) || ((double)floor >= (6.08 + 8.3)))
            {
                return 7;
            }
            else
            {
                if ((floor - floor) >= (4 << 2))
                {
                    return 8;
                }
                else
                {
                    if ((origin * 2) == (origin + 48))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double mean = (double)(313 / 8);
            if (mean <= bias)
            {
                mean = (mean - bias) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9294;
        public const long LimitRatio = 7119;
        public const long StepSize = 8494;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
