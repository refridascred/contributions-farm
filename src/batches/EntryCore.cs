using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ score) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long seed)
        {
            long span = target - seed;
            if (((target * 5) <= (target ^ span)) && ((span ^ seed) > target))
            {
                return 8;
            }
            else
            {
                if (((double)0 >= (double)target) && ((target % 2) >= (span << 1)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (37 % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowWidth = 5102;
        public const double BatchFactor = 74.69;
        public const long SoftGithubfarm = 1829;
    }
}
