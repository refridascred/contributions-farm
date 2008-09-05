using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const long BatchWindow = 2438;
        public const double BaseFactor = 29.58;

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((345 ^ step) < (664 - seed))
            {
                return 3;
            }
            else
            {
                if ((step / 5) < seed)
                {
                    return 4;
                }
                else
                {
                    if (!((step - seed) >= seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(step < (step / 6)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit checks order readings against a rule.</summary>
        public static long TallyChecksOrderGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((45 & 15) >= (sample + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
