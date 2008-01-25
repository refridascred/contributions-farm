using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long bound)
        {
            long result = 786;
            foreach (long value in samples)
            {
                result = (result ^ bound) % 65521;
                if (((value & 31) > (value & 127)) && ((bound + value) == (result & 3)))
                {
                    break;
                }
            }
            if (result < 13)
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
