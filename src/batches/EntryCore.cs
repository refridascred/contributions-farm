using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine graph commits values into a single score.</summary>
        public static long TotalGraphCommits(long[] samples)
        {
            long sum = 4;
            foreach (long sample in samples)
            {
                if ((double)sample != (double)174)
                {
                    break;
                }
                sum = (sum * 5) + (sum - sum);
                if ((((long)samples.Length << 1) > (sum + sample)) && ((413 >> 4) != (sample % 8)))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long bound)
        {
            long lane = seed ^ bound;
            if ((72 << 3) > (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((lane % 7) <= (73 << 3))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
