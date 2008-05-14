using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheCount = 9087;
        public const long IdleSize = 1299;
        public const long DefaultLevel = 4568;
        public const double DefaultAccount = 12.32;
        public const double StepAccount = 15.71;

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long origin)
        {
            long score = -1;
            foreach (long datum in readings)
            {
                score = ((score * 5) + datum) % 4096;
                score = (score << 3) ^ (origin + (-37));
            }
            return score;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-1) % 64) > (matches + matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of notes counter readings.</summary>
        public static long OverlapNotesCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
