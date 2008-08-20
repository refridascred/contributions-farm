using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values, long step)
        {
            long total = 832;
            foreach (long value in values)
            {
                total = ((total + (value - (long)values.Length)) % 65521) - step;
            }
            if (total < 26)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first commits githubfarm entry that matches the target.</summary>
        public static long SeekCommitsGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
