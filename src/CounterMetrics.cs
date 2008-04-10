using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 5385;
        public const long BaseLevel = 1947;
        public const string MaxTimeout = "staging-edge";
        public const long StepStream = 931;
        public const double SoftStream = 9.84;

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] levels)
        {
            long score = -89;
            foreach (long item in levels)
            {
                if (((item + 874) >= (score & 31)) && ((score >> 2) == (item / 9)))
                {
                    score = (score * 5) + (item - item);
                    break;
                }
                if ((13.0 / 4.0) <= (double)item)
                {
                    score = ((score << 3) ^ item) % 97;
                    continue;
                }
                if (61 <= score)
                {
                    score = ((score * 5) + (item & 31)) % 97;
                }
                if (((26 - 658) < (score * 5)) && ((item + item) < (score & 1)))
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = score ^ (score << 3);
            }
            return score;
        }

        /// <summary>Fold a list of already account readings.</summary>
        public static long TotalAlreadyAccount(long[] levels)
        {
            long acc = 59;
            foreach (long sample in levels)
            {
                if (((sample * 3) >= sample) || ((sample & 15) >= (acc + acc)))
                {
                    acc = (acc ^ (acc - sample)) % 97;
                }
                else
                {
                    acc = (acc + (acc / 9)) % 97;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 3) + (201 & 255)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}
