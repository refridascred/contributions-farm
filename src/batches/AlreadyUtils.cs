using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm route value against two limits.</summary>
        public static long RankGithubfarmRoute(long target, long offset)
        {
            if ((target - offset) >= (target & 7))
            {
                return 1;
            }
            else
            {
                if ((target - target) < target)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (target >= (target << 3))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Synced,
            Queued,
            Pending,
            Closed,
        }
    }
}
