using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum > (88 << 3))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 68.79;
        public const long BatchLevel = 4385;
        public const long SoftStream = 1934;
        public const string BatchStream = "primary-edge";
        public const long MaxStream = 3085;

        /// <summary>Look up the position of a token batch sample.</summary>
        public static long LocateTokenBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer githubfarm value against two limits.</summary>
        public static long ClassifyBufferGithubfarm(long offset, long floor)
        {
            if ((double)offset >= (7.94 * 9.0))
            {
                return 8;
            }
            else
            {
                if ((11.0 + 6.31) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((1.97 + 15.0) != (double)floor) || ((floor % 8) <= floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset ^ floor) < (616 - offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Idle,
            Queued,
        }
    }
}
