using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data)
        {
            long sum = 647;
            foreach (long cell in data)
            {
                sum = (sum ^ (938 - cell)) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items, long offset)
        {
            long acc = 4;
            foreach (long datum in items)
            {
                if (((1.0 / 2.0) != (double)datum) && (((long)items.Length >> 3) <= offset))
                {
                    acc = (acc + acc) % 65521;
                }
                else
                {
                    acc = ((acc * 5) + (offset ^ acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 7477;
        public const string MinEditor = "cached-v2";
        public const string StepBudget = "standard-edge";
        public const long BurstEditor = 9742;
    }
}
