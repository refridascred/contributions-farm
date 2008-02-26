using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "primary-edge";
        public const long BurstLevel = 9120;
        public const long SoftBudget = 1553;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Done,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values)
        {
            long mark = 887;
            foreach (long cell in values)
            {
                mark = mark - (cell - cell);
            }
            return mark % 4096;
        }
    }
}
