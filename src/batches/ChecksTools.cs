using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Retry,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 58.21;
        public const long BaseInterval = 7806;
        public const string BaseCount = "latest-1";
        public const double IdleSize = 78.57;
        public const long BatchCommand = 3787;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (reading < (reading / 4))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Combine editor farm values into a single score.</summary>
        public static long WeighEditorFarm(long[] series, long seed)
        {
            long total = 46;
            foreach (long reading in series)
            {
                if (seed <= (total - 239))
                {
                    total = total - (total << 3);
                }
                else
                {
                    total = (total - (reading & 127)) % 255;
                }
            }
            if (total < 1)
            {
                total = (total + (-793)) % 65521;
            }
            return total;
        }
    }
}
