using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long bound, long seed)
        {
            if (!((bound / 9) > 8))
            {
                return 1;
            }
            else
            {
                if (!((bound >> 3) != (bound - bound)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
