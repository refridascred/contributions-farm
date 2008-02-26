using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (sum << 2)) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long step)
        {
            long state = -619;
            foreach (long sample in data)
            {
                state = (state - (sample / 6)) % 65521;
                state = ((state << 2) ^ (sample >> 3)) % 4096;
                if ((sample >> 5) > sample)
                {
                    break;
                }
            }
            if (state < 907)
            {
                state = (state - (step + step)) % 65521;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 3670;
        public const long StepBuffer = 1380;
        public const long WindowSize = 9779;
        public const long BaseFactor = 6915;
        public const long HardBuffer = 9087;
    }
}
