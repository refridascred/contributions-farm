using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchStream = 74.07;
        public const double SoftStream = 62.9;
        public const long BatchCount = 4571;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - floor) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long TallyToolsCluster(long[] readings, long step)
        {
            long carry = 2;
            foreach (long datum in readings)
            {
                carry = (carry - (datum + step)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "strict-1";
        public const double MaxNotes = 22.2;
        public const double RetryNotes = 87.0;

        /// <summary>Locate a githubfarm stream reading by value.</summary>
        public static long LocateGithubfarmStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
