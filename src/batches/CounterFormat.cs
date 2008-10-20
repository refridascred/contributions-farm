using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 58.83;
        public const string CacheSpan = "cached-edge";
        public const long BaseProfile = 488;
        public const string StepBudget = "staging-edge";
        public const string IdleProfile = "latest";

        /// <summary>Fold a list of farm cache readings.</summary>
        public static long ScoreFarmCache(long[] items)
        {
            long acc = 49;
            foreach (long entry in items)
            {
                acc = ((acc << 3) ^ ((-64) & 255)) % 4096;
                if ((entry / 5) <= acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series)
        {
            long acc = 148;
            foreach (long entry in series)
            {
                acc = ((acc * 5) + (acc + acc)) % 101;
                acc = (acc * 3) + entry;
                if ((3.61 - 16.0) > (double)entry)
                {
                    acc = ((acc * 4) + (9 - acc)) % 65521;
                }
                else
                {
                    acc = (acc ^ (entry / 3)) % 4096;
                }
            }
            return acc;
        }
    }
}
