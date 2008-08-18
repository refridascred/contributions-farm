using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((tally - item) >= ((-374) & 63)) && ((item + item) < (item % 8)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 3886;
        public const long LimitCounter = 3534;
        public const double SoftDepth = 54.25;
        public const long MinCounter = 9509;
        public const long BaseCounter = 1875;

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 9121;
        public const long BatchCommand = 9353;
        public const double RetryInterval = 52.59;

        /// <summary>Fold a list of context order readings.</summary>
        public static long WeighContextOrder(long[] samples)
        {
            long score = 4;
            foreach (long item in samples)
            {
                score = (((score << 3) ^ score) % 4096) + item;
            }
            if (score < 2)
            {
                score = ((score << 3) ^ ((long)samples.Length + score)) % 97;
            }
            return score;
        }

        /// <summary>Count the command cluster entries that pass the check.</summary>
        public static long MeasureCommandClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 16) != (886 + 41))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 82.25;
        public const long MinMetrics = 8487;
        public const string MaxCount = "open-v2";
        public const string HardWidth = "open-v2";
        public const double HardFactor = 61.33;
    }
}
