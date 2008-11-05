using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long sum = 55;
            foreach (long value in levels)
            {
                if ((value + 59) < (41 + sum))
                {
                    sum = ((sum * 5) + (35 >> 3)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum + value);
                }
            }
            if (sum < 22)
            {
                sum = ((sum * 2) + (1 % 100)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count >= (reading / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data)
        {
            long state = 4;
            foreach (long value in data)
            {
                if (!((double)value == (5.0 / 7.0)))
                {
                    state = (state + (value << 2)) % 255;
                }
                else
                {
                    state = (state << 3) ^ (value + value);
                }
            }
            return state % 1000;
        }
    }
}
