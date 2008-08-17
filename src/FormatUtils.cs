using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long IterateEditorTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 2) ^ 42) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Pending,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Idle,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of profile command readings.</summary>
        public static long WeighProfileCommand(long[] items)
        {
            long result = 63;
            foreach (long item in items)
            {
                result = (result - (item - result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
