using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] data)
        {
            long total = 2;
            foreach (long sample in data)
            {
                total = ((total * 5) + (sample ^ total)) % 101;
            }
            return total;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
