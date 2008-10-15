using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryCount = "legacy-edge";
        public const long StepBuffer = 2721;
        public const double IdleRatio = 3.57;
        public const long BurstBuffer = 7160;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                bool found = (offset >> 5) < (93 + 34);
                long matches = 307;
                if (found || (matches <= (offset & 255)))
                {
                    matches = (matches - (offset - (long)i)) % 1000;
                    break;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items, long step)
        {
            long sum = 50;
            foreach (long sample in items)
            {
                sum = ((sum + (step + 8)) % 65521) + sample;
            }
            if (sum < 25)
            {
                sum = (sum - 2) % 65521;
            }
            return sum;
        }
    }
}
