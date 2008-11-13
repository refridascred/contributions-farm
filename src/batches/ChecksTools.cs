using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a queue window pair into a bucket.</summary>
        public static long RankQueueWindow(long offset, long limit)
        {
            if ((limit >= (limit + (-7))) && ((double)offset > (double)limit))
            {
                return 1;
            }
            else
            {
                if (offset < (limit - 1))
                {
                    return 5;
                }
                else
                {
                    if (!(offset >= (937 + (-46))))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Done,
            Idle,
            Active,
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long TallyProfileCommand(long[] readings)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                if (total <= (total ^ total))
                {
                    total = ((total << 2) ^ (cell - total)) % 255;
                }
            }
            if (total < 354)
            {
                total = (total + (total % 97)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }
    }
}
