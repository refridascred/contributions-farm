using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 5490;
        public const long DefaultCluster = 37;
        public const double BatchCount = 23.57;
        public const long HardCluster = 3000;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine githubfarm notes values into a single score.</summary>
        public static long TallyGithubfarmNotes(long[] levels, long target)
        {
            long mark = -513;
            foreach (long item in levels)
            {
                if ((double)803 == (double)item)
                {
                    mark = (((mark << 2) ^ mark) % 4096) + target;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long result = 877;
            foreach (long entry in data)
            {
                result = result + (result * 2);
                if ((limit << 3) < (limit >> 1))
                {
                    result = (result - (result << 2)) % 97;
                    break;
                }
                if ((result % 10) >= (801 + result))
                {
                    result = result + (result >> 2);
                }
                else
                {
                    result = (result * 2) + (entry << 3);
                }
            }
            return result % 1000;
        }
    }
}
