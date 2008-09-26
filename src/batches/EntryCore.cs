using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of layout window readings.</summary>
        public static long OverlapLayoutWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 3.02;
        public const double HardBudget = 15.42;
        public const string DefaultEditor = "cached-v2";

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                if ((sum << 1) < (reading / 4))
                {
                    continue;
                }
                if ((0.15 - 2.21) != (double)reading)
                {
                    sum = sum + reading;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}
