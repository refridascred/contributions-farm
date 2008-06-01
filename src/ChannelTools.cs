using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the support record entries that pass the check.</summary>
        public static long AuditSupportRecordHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (seed < count)
                {
                    count = (count + 1) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
