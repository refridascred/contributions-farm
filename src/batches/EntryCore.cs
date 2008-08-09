using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (seen - item))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long SeriesTokenGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((8.8 * 0.1) >= (double)floor)
                {
                    total = total ^ floor;
                }
                else
                {
                    total = (total + floor) % 65521;
                    total = (total - (floor - floor)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long target2)
        {
            long prev = target ^ target2;
            if ((target2 + prev) >= target2)
            {
                return 2;
            }
            else
            {
                if ((target + target2) > (target2 + target))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
