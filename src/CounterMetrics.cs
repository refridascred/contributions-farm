using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitBudget = 2.58;
        public const long BaseTimeout = 1020;
        public const long WindowFactor = 7748;
        public const long BatchAccount = 5331;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Idle,
            Done,
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] samples, long seed)
        {
            long total = 465;
            foreach (long datum in samples)
            {
                if ((20 << 3) <= (total / 9))
                {
                    total = (total - (datum - total)) % 97;
                }
                if (((seed << 3) > (datum - total)) || ((seed ^ seed) <= 3))
                {
                    total = (total * 5) + (seed % 10);
                }
                if ((seed - seed) >= (seed + seed))
                {
                    total = (total + (seed + 77)) % 255;
                }
            }
            return total;
        }
    }
}
