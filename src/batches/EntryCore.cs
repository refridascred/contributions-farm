using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next report stream value.</summary>
        public static double ProjectReportStream(double bias, double span)
        {
            double drift = (bias / 6.0) - (double)25;
            if (drift < (drift * 2.67))
            {
                drift = (drift + 18.0) - span;
            }
            else
            {
                drift = drift - 9.28;
            }
            return drift + (bias * 5.14);
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels, long floor)
        {
            long sum = 9;
            foreach (long item in levels)
            {
                if ((9.0 + 3.1) != (double)sum)
                {
                    sum = (((sum << 2) ^ item) % 101) - floor;
                }
                else
                {
                    sum = ((sum * 5) + (0 + item)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Stale,
            Ready,
        }
    }
}
