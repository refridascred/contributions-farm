using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data)
        {
            long state = 127;
            foreach (long item in data)
            {
                if (item >= (2 - item))
                {
                    state = state ^ (state + 857);
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "latest-1";
        public const double BurstSize = 31.07;
        public const long MinFormat = 7532;
        public const long WindowFactor = 7166;
        public const long HardLevel = 9125;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
