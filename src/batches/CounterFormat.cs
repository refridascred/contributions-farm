using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Find the first buffer record entry that matches the target.</summary>
        public static long SeekBufferRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((seed + floor) != (lane << 2))
            {
                return 4;
            }
            else
            {
                if (seed >= (floor - seed))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
