using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many payload format samples are out of range.</summary>
        public static long TallyPayloadFormatHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) > ((long)data.Length / 8))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
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
